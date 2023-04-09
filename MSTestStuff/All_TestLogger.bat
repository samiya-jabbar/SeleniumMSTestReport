@ECHO OFF
ECHO Demo Automation Executed Started.

set dllpath=D:\EducationalStuff\AllCourses\SQABootCamp\Automation\SeleniumMSTestReport\bin\Debug\SeleniumMSTestReport.dll
set trxerpath=D:\EducationalStuff\AllCourses\SQABootCamp\Automation\SeleniumMSTestReport\MSTestStuff
set SummaryReportPath=D:\EducationalStuff\AllCourses\SQABootCamp\Automation\SeleniumMSTestReport\MSTestStuff

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename="AutoGeneratedMSTestReport"
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /ResultsDirectory:%SummaryReportPath% /Logger:"trx";

cd %trxerpath%

TrxToHTML.exe %SummaryReportPath%

PAUSE