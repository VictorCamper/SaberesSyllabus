SETLOCAL
SET directory=.
SET mysqldir="C:\wamp\bin\mysql\mysql5.7.19\bin
SET user=root
SET pwd=
SET dbname=syllabus
SET server=localhost

for %%f in (.\*.sql) do %mysqldir%\mysql" --user=%user% --password=%pwd% --host=%server% %dbname%   --default-character-set=utf8 < %%f
ENDLOCAL
PAUSE