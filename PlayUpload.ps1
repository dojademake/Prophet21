# Define your credentials and server details
$sftpServer = "usafileupload.epicorsaas.com"
$sftpPort = 47506
$sftpUser = "user.name"
$sftpPassword = "#####"
$securePassword = ConvertTo-SecureString $sftpPassword -AsPlainText -Force
$credential = New-Object System.Management.Automation.PSCredential -ArgumentList $sftpUser, $securePassword

# Establish an SFTP connection
$session = New-SFTPSession -HostName $sftpServer -Port $sftpPort -Credential $credential

# Set the local and remote paths
$localPath = "D:\Repos\GitHub\Prophet21\P21.Rules.Visual\bin\app.publish\*"
$remotePath = "/COMPANYNAME/Shared/WebVisualRules/Play"

# Upload the files using Set-SFTPItem
Get-ChildItem $localPath | ForEach-Object {
    $localFilePath = $_.FullName
    Set-SFTPItem -SessionId $session.SessionId -Path $localFilePath -Destination $remotePath -Force
}

# Close the SFTP session
Remove-SFTPSession -SessionId $session.SessionId
