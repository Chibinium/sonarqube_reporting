set DOTCOVER=D:\devtools\dotCover_CLI\dotCover.exe
set WORKINGDIR=C:\Users\corba\Documents\visual studio 2015\Projects\HelloWorld\
set VSTEST=D:\devtools\TestWindow\vstest.console.exe

%DOTCOVER% analyze ^
 "/TargetExecutable=%VSTEST%" ^
 "/TargetArgument" ^
 /Output="%WORKINGDIR%\dotCover.html" ^
 /ReportType=HTML ^
 "/TargetArguments=..\HelloWorldTest\bin\debug\HelloWorldTest.dll"