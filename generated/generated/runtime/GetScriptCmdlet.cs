using System.Linq;
using System.Management.Automation;
using static Sample.API.Runtime.PowerShell.PsHelpers;

namespace Sample.API.Runtime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ScriptCmdlet")]
    [OutputType(typeof(string[]))]
    [DoNotExport]
    public class GetScriptCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ScriptFolder { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(GetScriptCmdlets(this, ScriptFolder)
                .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
                .Select(fi => fi.Name), true);
        }
    }
}
