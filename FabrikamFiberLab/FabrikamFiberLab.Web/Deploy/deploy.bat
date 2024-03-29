REM set build path
set buildpath=%1

REM set deployment path
set deploypath="c:\deploy"

REM create deployment directory
if not exist %deploypath% (cmd /c mkdir %deploypath%)

REM copy build to the deployment directory
xcopy /c /y /e %buildpath%\*.* %deploypath%

REM xcopy deploy over production Fabrikam site
del /q /f /s c:\inetpub\FabrikamFiberLab.Web\*.*
for /d %%x in (c:\inetpub\FabrikamFiberLab.Web\*) do @rd /s /q %%x
xcopy /c /y /e %deploypath%\_PublishedWebsites\FabrikamFiberLab.Web\*.* c:\inetpub\FabrikamFiberLab.Web
