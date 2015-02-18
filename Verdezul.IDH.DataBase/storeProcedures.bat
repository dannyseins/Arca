echo off
cls
for %%f in (ChangeScripts\Alumno\*.sql) do type "%%f" >> Alumno.psql
for %%f in (ChangeScripts\Area\*.sql) do type "%%f" >> Area.psql
for %%f in (ChangeScripts\Aula\*.sql) do type "%%f" >> Aula.psql
for %%f in (ChangeScripts\CierreDeCaja\*.sql) do type "%%f" >> CierreDeCaja.psql
for %%f in (ChangeScripts\Conferencia\*.sql) do type "%%f" >> Conferencia.psql
for %%f in (ChangeScripts\Curso\*.sql) do type "%%f" >> Curso.psql
for %%f in (ChangeScripts\Docente\*.sql) do type "%%f" >> Docente.psql
for %%f in (ChangeScripts\EstadoAlumno\*.sql) do type "%%f" >> EstadoAlumno.psql
for %%f in (ChangeScripts\Horario\*.sql) do type "%%f" >> Horario.psql
for %%f in (ChangeScripts\HorarioAlumno\*.sql) do type "%%f" >> HorarioAlumno.psql
for %%f in (ChangeScripts\Nivel\*.sql) do type "%%f" >> Nivel.psql
for %%f in (ChangeScripts\Observacion\*.sql) do type "%%f" >> Observacion.psql
for %%f in (ChangeScripts\Pago\*.sql) do type "%%f" >> Pago.psql
for %%f in (ChangeScripts\Parametro\*.sql) do type "%%f" >> Parametro.psql
for %%f in (ChangeScripts\Reportes\*.sql) do type "%%f" >> Reportes.psql
for %%f in (ChangeScripts\Rubro\*.sql) do type "%%f" >> Rubro.psql
for %%f in (ChangeScripts\SecuenciaImpresion\*.sql) do type "%%f" >> SecuenciaImpresion.psql
for %%f in (ChangeScripts\Usuario\*.sql) do type "%%f" >> Usuario.psql

del storeProcedures.sql
for %%f in (*.psql) do type "%%f" >> storeProcedures.sql

del *.psql
pause