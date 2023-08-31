# Define your credentials and server details
$sftpServer = "usafileupload.epicorsaas.com"
$sftpPort = 47506

# Get User Inputs
$sftpUser = Read-Host "Enter SFTP Username"
$sftpPassword = Read-Host "Enter SFTP Password" -AsSecureString
$localPath = Read-Host "Enter Local Path (Press Enter for default 'app.publish' path)" 
if ([string]::IsNullOrEmpty($localPath)) { $localPath = "C:\Repos\GitHub\Prophet21\P21.Rules.Visual\bin\app.publish\*" }

$remotePath = Read-Host "Enter Remote Path (Press Enter for default 'WebVisualRules' path)"
if ([string]::IsNullOrEmpty($remotePath)) { $remotePath = "/COMPANYNAME/Shared/WebVisualRules/Play" }

# Create the SFTP Session
$session = New-SFTPSession -HostName $sftpServer -Port $sftpPort -Credential (New-Object PSCredential ($sftpUser, $sftpPassword))

# Upload the files using Set-SFTPItem
Get-ChildItem $localPath | ForEach-Object {
    $localFilePath = $_.FullName
    Set-SFTPItem -SessionId $session.SessionId -Path $localFilePath -Destination $remotePath -Force
}

# Close the SFTP session
Remove-SFTPSession -SessionId $session.SessionId
