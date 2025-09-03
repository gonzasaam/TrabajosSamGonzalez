use MASTER
--'localhost' solo si se que estoy conectado en modo local a SQL si se conecta a una bd no funciona
CREATE LOGIN Gestor_BD 
	WITH PASSWORD ='Gestor_12454';
---------------------------------
CREATE LOGIN User_DB
	WITH PASsWORD = 'User_8520';
----USUARIO ADMIN
CREATE LOGIN Admin_DB
	WITH PASsWORD = 'Admin_8520';

USE CasaEstilo
--creacio de usuarios para la bD

CREATE USER Gestor_BD for login Gestor_BD;
ALTER ROLE db_datareader ADD MEMBER [Gestor_BD];

CREATE USER User_DB for login User_DB
ALTER ROLE db_datareader ADD MEMBER [User_DB]
-------
CREATE USER Admin_DB FOR LOGIN Admin_DB
alter role db_owner add member Admin_DB

ALTER ROLE db_datawriter DROP  MEMBER Gestor_BD

USE master

CREATE LOGIN Backup_BD
	WITH PASSWORD= 'Recover_8520'

use CasaEstilo

create user Backup_BD for login Backup_BD
alter role db_backupoperator add member Backup_BD


------ final ejercicio------