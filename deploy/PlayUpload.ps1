# Get User Inputs
$sftpUser = Read-Host "Enter SFTP Username"
$sftpPassword = Read-Host "Enter SFTP Password" -AsSecureString
$localPath = Read-Host "Enter Local Path (Press Enter for default 'app.publish' path)" 
if ([string]::IsNullOrEmpty($localPath)) { $localPath = "C:\Repos\GitHub\Prophet21\P21.Rules.Visual\bin\app.publish\*" }

$remotePath = Read-Host "Enter Remote Path (Press Enter for default 'WebVisualRules' path)"
if ([string]::IsNullOrEmpty($remotePath)) { $remotePath = "/[COMPANYNAME]/Shared/WebVisualRules/Play" }

# Create the SFTP Session
$session = New-SFTPSession -HostName $sftpServer -Port $sftpPort -Credential (New-Object PSCredential ($sftpUser, $sftpPassword))

# Loop through each local file
Get-ChildItem $localPath -File | ForEach-Object {
    $localFilePath = $_.FullName
    $localFileName = $_.Name

    $remoteFilePath = Join-Path $remotePath $localFileName # -Replace '\\','/'

    try {
        $remoteFile = Get-SFTPItem -SessionId $session.SessionId -Path $remoteFilePath -ErrorAction SilentlyContinue
    } catch {
        Write-Host "Remote file $remoteFilePath does not exist."
    }

    if ($null -eq $remoteFile -or $_.LastWriteTime -gt $remoteFile.LastWriteTime.ToLocalTime()) {
        Write-Host "Uploading $localFilePath to $remoteFilePath"
        Set-SFTPItem -SessionId $session.SessionId -LocalPath $localFilePath -RemotePath $remoteFilePath -Force
    }
}
