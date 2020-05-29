CREATE DATABASE NOM_035
USE NOM_035

/---------------------------------------------------------------------------/
						---  EMPLEADOS ----

CREATE TABLE EMPLEADO(
	ID_EMPLEADO		INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NOMBRE_EMPLEADO VARCHAR(100)      NOT NULL,
	EDAD_EMPLEADO	INT               NOT NULL,
	PUESTO			VARCHAR (100)     NOT NULL,
	TURNO           VARCHAR (100)     NOT NULL
)

INSERT INTO EMPLEADO VALUES('David Llanes'    ,22, 'Operador', 'Vespertino')
INSERT INTO EMPLEADO VALUES('Sergio Flores'   ,25, 'Operador', 'Matutino'  )
INSERT INTO EMPLEADO VALUES('Miguel Espinoza' ,21, 'Operador', 'Rotativo'  )


CREATE PROCEDURE SP_CREAR_EMPLEADO
	@nombre_empleado VARCHAR(100),
	@edad            INT,
	@puesto          VARCHAR(100),
	@turno           VARCHAR (100)
AS
BEGIN
	INSERT INTO EMPLEADO VALUES(@nombre_empleado, @edad, @puesto, @turno)
END


/----------------------------------------------------------------/
					---- SECCION I ----

CREATE TABLE SECCION_I(
	ID_SECCION_I      INT IDENTITY(1,1)  NOT NULL PRIMARY KEY,
	CUESTINARIO_I_I   VARCHAR(50)        NOT NULL
)


CREATE PROC SP_SECCION_I
	@cuestionario_i_i VARCHAR(50)
AS
BEGIN
	INSERT INTO SECCION_I VALUES (@cuestionario_i_i)
END


/---------------------------------------------------------------------/
				---- SECCION II ----

CREATE TABLE SECCION_II(
	ID_SECCION_II      INT IDENTITY(1,1)  NOT NULL PRIMARY KEY,
	CUESTIONARIO_II_I  VARCHAR(50)        NOT NULL,
	CUETIONARIO_II_II  VARCHAR(50)        NOT NULL
)

CREATE PROC SP_SECCION_II
	@cuestionario_ii_i   VARCHAR(50),
	@cuestionario_ii_ii  VARCHAR(50)
AS
BEGIN
	INSERT INTO SECCION_II VALUES (@cuestionario_ii_i , @cuestionario_ii_ii)
END
/--------------------------------------------------------------------/
				-----  SECCION III  -----

CREATE TABLE SECCION_III(
	ID_SECCION_III         INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CUESTIONARIO_III_I     VARCHAR(50) NOT NULL,
	CUESTIONARIO_III_II    VARCHAR(50) NOT NULL,
	CUESTIONARIO_III_III   VARCHAR(50) NOT NULL,
	CUESTIONARIO_III_IV    VARCHAR(50) NOT NULL,
	CUESTIONARIO_II_V      VARCHAR(50) NOT NULL,
	CUESTIONARIO_III_VI    VARCHAR(50) NOT NULL, 
	CUESTIONARIO_III_VII   VARCHAR(50) NOT NULL
)

CREATE PROC SP_SECCION_III
	@cuestionario_iii_i   VARCHAR(50),
	@cuestionario_iii_ii  VARCHAR(50),
	@cuestionario_iii_iii VARCHAR(50),
	@cuestionario_iii_iv  VARCHAR(50),
	@cuestionario_iii_v   VARCHAR(50),
	@cuestionario_iii_vi  VARCHAR(50),
	@cuestionario_iii_vii   VARCHAR(50)
AS
BEGIN
	INSERT INTO SECCION_III VALUES (@cuestionario_iii_i, @cuestionario_iii_ii,@cuestionario_iii_iii, @cuestionario_iii_iv, @cuestionario_iii_v, @cuestionario_iii_vi, @cuestionario_iii_vii)
END
	
/--------------------------------------------------------------------/
				----- SECCION IV -----

CREATE TABLE SECCION_IV(
	ID_SECCION_IV       INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	CUESTIONARIO_IV_I   VARCHAR(50) NOT NULL,
	CUESTIONARIO_IV_II  VARCHAR(50) NOT NULL,
	CUESTIONARIO_IV_III VARCHAR(50) NOT NULL,
	CUESTIONARIO_IV_IV  VARCHAR(50) NOT NULL,
	CUESTIONARIO_IV_V   VARCHAR(50) NOT NULL
)


CREATE PROC SP_SECCION_IV
	@cuestionario_iv_i   VARCHAR(50),
	@cuestionario_iv_ii  VARCHAR(50),
	@cuestionario_iv_iii VARCHAR(50),
	@cuestionario_iv_iv  VARCHAR(50),
	@cuestionario_iv_v   VARCHAR(50)
AS
BEGIN
	INSERT INTO SECCION_IV VALUES(@cuestionario_iv_i, @cuestionario_iv_ii, @cuestionario_iv_iii, @cuestionario_iv_iv, @cuestionario_iv_v)
END

/-----------------------------------------------------------------------------/
							--- CUESTIONARIO ---
CREATE TABLE CUESTIONARIO(
	ID_CUESTIONARIO INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	ID_EMPLEADO     INT FOREIGN KEY REFERENCES EMPLEADO    (ID_EMPLEADO),
	ID_SECCION_I    INT FOREIGN KEY REFERENCES SECCION_I   (ID_SECCION_I),
	ID_SECCION_II   INT FOREIGN KEY REFERENCES SECCION_II  (ID_SECCION_II),
	ID_SECCION_III  INT FOREIGN KEY REFERENCES SECCION_III (ID_SECCION_III),
	ID_SECCION_IV   INT FOREIGN KEY REFERENCES SECCION_IV  (ID_SECCION_IV)
)

DROP TABLE CUESTIONARIO

INSERT INTO CUESTIONARIO VALUES (1);
INSERT INTO CUESTIONARIO VALUES (2);
INSERT INTO CUESTIONARIO VALUES (3);

SELECT * FROM CUESTIONARIO
SELECT * FROM EMPLEADO


/----------------------------------------------------------------------------/
							--- ACCESO ---
CREATE TABLE ACCESO(
	USERNAME VARCHAR(50) NOT NULL,
	PASSWORD VARCHAR(50) NOT NULL
)

CREATE PROC SP_ACCESO
	@username varchar(50) = 'ADMIN',
	@pass varchar(50) = '123'
AS
BEGIN
	SELECT * FROM ACCESO WHERE USERNAME = @username AND PASSWORD = @pass
END

INSERT INTO ACCESO VALUES('ADMIN','123');

EXEC  SP_ACCESO

