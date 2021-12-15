try
{
Write-Host "`nCleaning DocuSign.eSign!" -ForegroundColor Yellow
msbuild ./sdk/src/DocuSign.eSign/DocuSign.eSign.csproj /t:clean /verbosity:minimal
if ($lastExitCode -ne 0) { exit $lastExitCode }

Write-Host "Restore DocuSign.eSign" -ForegroundColor Yellow
msbuild ./sdk/src/DocuSign.eSign/DocuSign.eSign.csproj /t:restore /p:TargetFramework=net45 /verbosity:minimal
if ($lastExitCode -ne 0) { exit $lastExitCode }

Write-Host "`nBuilding DocuSign.eSign for Net45" -ForegroundColor Yellow
msbuild ./sdk/src/DocuSign.eSign/DocuSign.eSign.csproj /p:TargetFramework=net45 /p:Configuration=Debug /verbosity:minimal
if ($lastExitCode -ne 0) { exit $lastExitCode }

Write-Host "`nRestore DocuSign.eSign for NetStandard2.0" -ForegroundColor Yellow
msbuild ./sdk/src/DocuSign.eSign/DocuSign.eSign.csproj /t:restore /p:TargetFramework=netstandard2.0 /verbosity:minimal
if ($lastExitCode -ne 0) { exit $lastExitCode }

Write-Host "`nBuilding DocuSign.eSign for NetStandard2.0" -ForegroundColor Yellow
msbuild ./sdk/src/DocuSign.eSign/DocuSign.eSign.csproj /p:TargetFramework=netstandard2.0 /p:Configuration=Debug /verbosity:minimal
if ($lastExitCode -ne 0) { exit $lastExitCode }
}
catch {
    Write-Host "`nSomething went wrong!" -ForegroundColor Red
    Write-Host "`nException Type: $($_.Exception.GetType().FullName)" -ForegroundColor Red
    Write-Host "`nException Message: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}
