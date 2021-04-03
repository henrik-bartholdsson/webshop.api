
#
#	This script creates Machine Environment variables
#	These then replaces AppSettings and ConnectionStrings in AppSettings.json
#	Fill this file with correct values
#



# ConnectionString's
Write-Output "Added Variable ConnectionStrings:WebShopDB"
[System.Environment]::SetEnvironmentVariable('ConnectionStrings:WebShopDB','Server=(localdb)\mssqllocaldb;Database=WebShop;Trusted_Connection=True;MultipleActiveResultSets=true',[System.EnvironmentVariableTarget]::Machine)