# Setup by installing https://winscp.net/eng/index.php and verifying the path below is accurate

# Load WinSCP .NET assembly
Add-Type -Path "C:\Program Files (x86)\WinSCP\WinSCPnet.dll"   # Verify the path to WinSCPnet.dll

# Set session options
$sessionOptions = New-Object WinSCP.SessionOptions
$sessionOptions.Protocol = [WinSCP.Protocol]::Sftp
$sessionOptions.HostName = "usafileupload.epicorsaas.com" # Verify the remote address and port
$sessionOptions.PortNumber = 45321
$sessionOptions.UserName = "user.name" # User with delete and write access to the SFTP folder
$sessionOptions.Password = "p@s5w0rD"
$sessionOptions.SshHostKeyFingerprint = "ssh-rsa 2048 xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx" # Get this value with an EpicCare ticket stating you need the SSH host key fingerprint

# Connect to the SFTP server
$session = New-Object WinSCP.Session
$session.Open($sessionOptions)

# Set paths
$environmentDirectory = "Play"
$remoteRootPath = "/COMPANYNAME/Shared/WebVisualRules/" # Specify your companies SFTP folder for the WVR virtual directory
$remoteEnvironmentPath = "${remoteRootPath}${environmentDirectory}/"
$remoteBinPath = "${remoteEnvironmentPath}bin/"
$localPath = "C:\Repos\Prophet21\P21Custom.Rules.Visual\bin\app.publish\*" # Replace with the actual environment

# Upload the app_offline.html file to the root directory
$localAppOfflinePath = "C:\Path\To\Your\app_offline.html" # Specify the path to your app_offline.html file
$remoteAppOfflinePath = "${remoteEnvironmentPath}app_offline.html"
$session.PutFiles($localAppOfflinePath, $remoteAppOfflinePath).Check()

# Delete remote files in the bin directory
$session.RemoveFiles("${remoteBinPath}*")

# Upload local files to the remote directory
$session.PutFiles($localPath, $remoteEnvironmentPath).Check()

# Remove the app_offline.html file
$session.RemoveFiles($remoteAppOfflinePath)

# Disconnect from the SFTP server
$session.Dispose()
