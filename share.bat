@echo off
echo ==========================================
echo Starting Developer Toolkit Shared Link...
echo ==========================================
echo.
echo Make sure your project is running in Visual Studio on port 5051 first!
echo.
powershell -ExecutionPolicy Bypass -Command "npx localtunnel --port 5051"
pause
