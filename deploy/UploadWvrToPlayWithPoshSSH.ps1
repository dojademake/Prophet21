# Setup (these steps are only need the first time) - Run Windows PowerShell as and Administrator for this section
Install-Module PSFTP # Answer Y to the NuGet provider is required to continue ... import the NuGet provider now? prompt
Import-Module PSFTP # Reply Y for the Untrusted repository ... install the modules from 'PSGallery'? also
Get-Command -Module Posh-SSH
Import-Module Posh-SSH

# Define your credentials and server details
$sessionParams = @{
    HostName = "usafileupload.epicorsaas.com"
    PortNumber = 45321
    UserName = "user.name"
    Password = "p@s5w0rD"
}

# Create SFTP session
$session = New-SFTPSession @sessionParams

# Set the local and remote paths
$localPath = "C:\Repos\Prophet21\P21Custom.Rules.Visual\bin\app.publish\*" # Replace with the actual environment

# Specify remote directory
$environmentDirectory = "Play"  # Replace with the actual environment
$wvrRemotePath = "/CompanyName/Shared/WebVisualRules" # Specify your companies SFTP folder for the WVR virtual directory

$remotePathBin = "$wvrRemotePath/$environmentDirectory/bin/"

# List files in remote directory
$remoteFiles = Get-SFTPChildItem -Session $session -Path $remotePathBin

# Delete remote files
foreach ($file in $remoteFiles) {
    Remove-SFTPItem -Session $session -Path $file.FullName
}

# Upload the files using Set-SFTPItem
$remotePathRoot = "$wvrRemotePath/$environmentDirectory/"
Get-ChildItem $localPath | ForEach-Object {
    $localFilePath = $_.FullName
    Set-SFTPItem -SessionId $session.SessionId -Path $localFilePath -Destination $remotePathRoot -Force
}

# Close the SFTP session
Remove-SFTPSession -SessionId $session.SessionId

