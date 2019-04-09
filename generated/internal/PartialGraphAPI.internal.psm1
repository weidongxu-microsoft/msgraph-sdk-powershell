# region Initialization
  # Load the private module dll
  $null = Import-Module -PassThru -Name (Join-Path $PSScriptRoot '..\bin\PartialGraphAPI.private.dll')

  # Load the custom module
  #$customModulePath = Join-Path $PSScriptRoot '..\custom\PartialGraphAPI.custom.psm1'
  #if(Test-Path $customModulePath) {
    #$null = Import-Module -Name $customModulePath
  #}

  # Export nothing to clear implicit exports
  Export-ModuleMember
# endregion

# region LoadScripts
  Get-ChildItem -Path $PSScriptRoot -Recurse -Filter '*.ps1' -File | ForEach-Object { . $_.FullName }
  Export-ModuleMember -Function (Get-ScriptCmdlet -ScriptFolder $PSScriptRoot)
# endregion
