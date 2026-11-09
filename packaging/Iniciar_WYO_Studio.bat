@echo off
setlocal
rem Dados e cache do aplicativo ficam em D:\GAME quando esse disco estiver disponível.
set "APP_DIR=%~dp0"
if exist "D:\GAME\" (
  set "WYO_MIDGARD_HOME=D:\GAME\MidgardStudio_WYO_Digital"
) else (
  set "WYO_MIDGARD_HOME=%APP_DIR%Data"
)
set "DOTNET_BUNDLE_EXTRACT_BASE_DIR=%WYO_MIDGARD_HOME%\runtime-cache"
if not exist "%DOTNET_BUNDLE_EXTRACT_BASE_DIR%" mkdir "%DOTNET_BUNDLE_EXTRACT_BASE_DIR%" 2>nul
if not exist "%APP_DIR%Midgard Studio WYO Digital.exe" (
  echo Executavel nao encontrado nesta pasta.
  pause
  exit /b 1
)
start "" "%APP_DIR%Midgard Studio WYO Digital.exe"
endlocal
