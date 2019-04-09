@{
# region definition
  RootModule = './PartialGraphAPI.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/PartialGraphAPI.private.dll'
  FormatsToProcess = './PartialGraphAPI.format.ps1xml'
# endregion

# region persistent data
  GUID = 'e6a3d762-62fc-4b63-848c-e385e7ddad17'
# endregion

# region private data
  PrivateData = @{
    PSData = @{
      Tags = ''
      LicenseUri = ''
      ProjectUri = ''
      ReleaseNotes = ''
    }
  }
# endregion

# region exports
  CmdletsToExport = 'Invoke-MeUserGetUser', '*'
# endregion

}