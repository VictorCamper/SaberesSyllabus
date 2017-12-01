SETLOCAL
SET directory=.
SET mysqldir="directory here
SET user=root
SET pwd=
SET dbname=
SET server=localhost

for %%f in (.\*.sql) do %mysqldir%\mysql" --user=%user% --password=%pwd% --host=%server% %dbname% < %%f
ENDLOCAL
PAUSE