CREATE DATABASE nominasoft;
Use nominasoft;


CREATE TABLE Empleado(

	idEmpleado int IDENTITY(1,1) constraint PK_IDEMPLEADO primary key,
	dni varchar(8),
	direccion varchar(50),
	estadoCivil varchar(30),
	fechaNacimiento date,
	GradoAcademico varchar(30),
	telefono varchar(20),
	nombre varchar(50)
);

CREATE TABLE AFP(
	idAfp int IDENTITY(1,1) constraint PK_IDAFP primary key,
	nombre varchar(50),
	porcentajeDeDescuento decimal(18,2)
);
CREATE TABLE Contrato(
	idContrato int IDENTITY(1,1) constraint PK_IDCONTRATO primary key,
	asignacionFamiliar bit,
	cargo varchar(30),
	fechaInicial date,
	fechaFinal date,
	horasContradasPorSemana int,
	valorHora int,
	estado bit,
	-----------------------------------------------------------------------
	ID_AFP int constraint FK_CONTRATO_AFP foreign key references AFP(idAfp),
	ID_EMPLEADO int constraint FK_CONTRATO_EMPLEADO foreign key references Empleado(idEmpleado)
);

CREATE TABLE Periodo(
	idPeriodo int IDENTITY(1,1) constraint PK_IDPeriodo primary key,
	fechaInicio date,
	fechaFin date,
	estado bit
);
CREATE TABLE Contrato_periodo(
	id int IDENTITY(1,1) constraint PK_Contrato_periodo primary key,
	ID_PERIODO int  constraint FK_CP_PERIODO foreign key references Periodo(idPeriodo),
	ID_CONTRATO int constraint FK_CP_CONTRATO foreign key references Contrato(idContrato)
)

CREATE TABLE CID(
	idCID int IDENTITY(1,1) constraint PK_IDCID primary key,
	montoHorasExtras decimal(18,2),
    montoHorasAusente decimal(18,2),
    montoOtrosDescuentos decimal(18,2),
    montoPorAdelanto decimal(18,2),
    montoOtrosIngresos decimal(18,2),
    montoReingreso decimal(18,2),
	-----------------------------------------------------------------------
	ID_CONTRATO_PERIODO int  constraint FK_CID_CP foreign key references Contrato_periodo(id)
);

CREATE TABLE Pago(
	idPago int IDENTITY(1,1) constraint PK_IDPAGO primary key,
	fechaActual date,
	montoAsignacionAFP decimal(18,2),
	descuentoAFP decimal(18,2),
	sueldoMinimo decimal(18,2),
	porsentajeDescuento decimal(18,2),
	valorHora decimal(18,2),
	totalHora decimal(18,2),
	-----------------------------------------------------------------------
	ID_PERIODO int  constraint FK_PAGO_PERIODO foreign key references Periodo(idPeriodo),
	ID_CONTRATO int constraint FK_PAGO_CONTRATO foreign key references Contrato(idContrato)
);

--      PROCEDURES
go
create procedure InsertarContrato
(
	@asignacionFamiliar bit,
	@cargo varchar(30),
	@fechaInicial date,
	@fechaFinal date,
	@horasContradasPorSemana int,
	@valorHora int,
	@estado bit,
	@ID_AFP int ,
	@ID_EMPLEADO int )
as
begin
insert into Contrato (asignacionFamiliar,cargo,fechaInicial,fechaFinal,horasContradasPorSemana,valorHora,estado,ID_AFP,ID_EMPLEADO)
values(@asignacionFamiliar ,
	@cargo ,
	@fechaInicial ,
	@fechaFinal ,
	@horasContradasPorSemana ,
	@valorHora ,
	@estado,
	@ID_AFP  ,
	@ID_EMPLEADO ) 
end
go
create procedure ListarContratosProcesar
(@ID_PERIODO int)
as
begin
	select * from Contrato inner join Contrato_periodo on  Contrato.idContrato = Contrato_periodo.ID_CONTRATO inner join Periodo on Periodo.idPeriodo = Contrato_periodo.ID_PERIODO
where Periodo.idPeriodo = @ID_PERIODO;
end
go
ListarContratosProcesar @ID_PERIODO = 1 ;
go
create procedure InsertarPago
(
	@fechaActual date,
	@montoAsignacionAFP decimal(18,2),
	@descuentoAFP decimal(18,2),
	@sueldoMinimo decimal(18,2),
	@porsentajeDescuento decimal(18,2),
	@valorHora decimal(18,2),
	@totalHora decimal(18,2),
	@ID_PERIODO int,
	@ID_CONTRATO int )
as
begin
insert into Pago (fechaActual, montoAsignacionAFP, descuentoAFP,sueldoMinimo, porsentajeDescuento, valorHora, totalHora,ID_PERIODO,ID_CONTRATO)
values(@fechaActual ,
	@montoAsignacionAFP ,
	@descuentoAFP ,
	@sueldoMinimo ,
	@porsentajeDescuento ,
	@valorHora ,
	@totalHora,
	@ID_PERIODO,
	@ID_CONTRATO) 
end
go
create procedure ActualizarPeriodo
(
	@idPeriodo int,
	@fechaInicio date,
	@fechaFin date,
	@estado bit)
as
begin
	update Periodo set fechaInicio = @fechaInicio, fechaFin = @fechaFin, estado = @estado where idPeriodo = @idPeriodo
end
go
create procedure ActualizarContrato
(
	@idContrato int,
	@asignacionFamiliar bit,
	@cargo varchar(30),
	@fechaInicial date,
	@fechaFinal date,
	@horasContradasPorSemana int,
	@valorHora int,
	@estado bit,
	@ID_AFP int,
	@ID_EMPLEADO int
)
as
begin
	update Contrato set asignacionFamiliar = @asignacionFamiliar, cargo = @cargo, fechaInicial = @fechaInicial,
	fechaFinal = @fechaFinal, horasContradasPorSemana = @horasContradasPorSemana, valorHora = @valorHora, estado = @estado,
	ID_AFP = @ID_AFP, ID_EMPLEADO = @ID_EMPLEADO where idContrato = @idContrato
end
go
--------------------------------------------------------------------------------------------------------
--         FIN  PROCEDURES 



--    EMPLEADOS
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('01234567','Avenida Arequipa 545 ','CASADO','2001-10-29','Universitario','044531282','Jorge Chavez');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('12345678','Avenida Brazil 656   ','CASADO','2001-10-29','Universitario','044123456','Pedro Castillo');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('23456789','Avenida Cesar 334    ','Soltero','2001-10-29','Universitario','044567893','Juan Perez');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('34567890','Avenida Sandoval 223 ','Soltero','2001-10-29','Universitario','044332434','Alberto Cuadro');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('45678901','Avenida America 432  ','CASADO','2001-10-29','Universitario','044456754','Paolo Guerrero');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('56789012','Avenida Larco 1223   ','Soltero','2001-10-29','Universitario','044763564','Gianluca Lapadula');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('67890123','Avenida Brazil 696   ','CASADO','2001-10-29','Universitario','044234523','Cristian Cueva');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('78901234','Avenida Arequipa 599 ','Soltero','2001-10-29','Universitario','044435555','Cristiano Ronaldo');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('89012345','Avenida Cesar 874    ','CASADO','2001-10-29','Universitario','044907097','Renzo Gonzales');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('90123456','Avenida Cesar 345    ','CASADO','2001-10-29','Universitario','044789870','Ricardo Armendia');

insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('00112233','Avenida Arequipa 599 ','CASADO','2001-10-29','Universitario','044435555','Carlos Ronaldo');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('11223344','Avenida Larco 332    ','Soltero','2001-10-29','Universitario','044879790','Rafael Carrazco');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('22334455','Avenida Sandoval 765 ','Soltero','2001-10-29','Universitario','044098709','Pedro Quinteros');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('33445566','Avenida America 555  ','CASADO','2001-10-29','Universitario','044543223','Toño Sneyder');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('44556677','Avenida Brazil 686   ','Soltero','2001-10-29','Universitario','044344323','Brayan Villalobos');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('55667788','Avenida Arequipa 876 ','Soltero','2001-10-29','Universitario','044634565','Federico Peña');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('66778899','Avenida Sandoval 223 ','CASADO','2001-10-29','Universitario','044332434','Coco Cuadro');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('77889900','Avenida America 432  ','Soltero','2001-10-29','Universitario','044456754','Kevin Guerrero');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('88990011','Avenida Larco 1223   ','Soltero','2001-10-29','Universitario','044763564','Jaime Rosas');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('99001122','Avenida Brazil 696   ','Soltero','2001-10-29','Universitario','044234523','Julio Cruz');

go

--    AFP
insert into afp(nombre,porcentajeDeDescuento) values ('HABITAT',13.21);
insert into afp(nombre,porcentajeDeDescuento) values ('INTEGRA',13.29);
insert into afp(nombre,porcentajeDeDescuento) values ('PRIMA',13.34);
insert into afp(nombre,porcentajeDeDescuento) values ('PROFUTURO',13.43);
insert into afp(nombre,porcentajeDeDescuento) values ('PROMEDIO',13.34);
go

--    CONTRATOS ANEXO 1 
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	5 ,@ID_EMPLEADO= 1;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	4 ,@ID_EMPLEADO= 2;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	3 ,@ID_EMPLEADO= 3;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	2 ,@ID_EMPLEADO= 4;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	1 ,@ID_EMPLEADO= 5;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	5 ,@ID_EMPLEADO= 6;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	4 ,@ID_EMPLEADO= 7;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	3 ,@ID_EMPLEADO= 8;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Gerente	 ', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	16	,@valorHora= 50	,@estado=true,@ID_AFP=	2 ,@ID_EMPLEADO= 9;
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Logística ', @fechaInicial='	2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	28	,@valorHora= 40	,@estado=true,@ID_AFP=	1 ,@ID_EMPLEADO= 10;
go


--   CONTRATOS ANEXO 2
InsertarContrato @asignacionFamiliar = false, @cargo = 'Trabajador', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	5 ,@ID_EMPLEADO= 11;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Trabajador', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	4 ,@ID_EMPLEADO= 12;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Trabajador', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	3 ,@ID_EMPLEADO= 13;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Trabajador', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	2 ,@ID_EMPLEADO= 14;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Trabajador', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-09-21 ',@horasContradasPorSemana=	20	,@valorHora= 30	,@estado=true,@ID_AFP=	1 ,@ID_EMPLEADO= 15;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Logística ', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	28	,@valorHora= 40	,@estado=true,@ID_AFP=	5 ,@ID_EMPLEADO= 16;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Logística ', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	28	,@valorHora= 40	,@estado=true,@ID_AFP=	4 ,@ID_EMPLEADO= 17;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Logística ', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	28	,@valorHora= 40	,@estado=true,@ID_AFP=	3 ,@ID_EMPLEADO= 18;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Logística ', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	28	,@valorHora= 40	,@estado=true,@ID_AFP=	2 ,@ID_EMPLEADO= 19;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Logística ', @fechaInicial=' 2021-04-21 ',@fechaFinal=' 2021-12-21 ',@horasContradasPorSemana=	28	,@valorHora= 40	,@estado=true,@ID_AFP=	1 ,@ID_EMPLEADO= 20;
go



--   PERIODOS
insert into Periodo(fechaInicio,fechaFin,estado) values ('2021-04-21','2021-05-21',1);

insert into Periodo(fechaInicio,fechaFin,estado) values ('2021-05-21','2021-06-21',1);

insert into Periodo(fechaInicio,fechaFin,estado) values ('2021-06-21','2021-07-21',1);

go



--     CONTRATO <-> PERIODO
-- CP ANEXO 1
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (1,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (1,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (1,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (2,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (2,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (2,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (3,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (3,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (3,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (4,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (4,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (4,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (5,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (5,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (5,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (6,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (6,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (6,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (7,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (7,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (7,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (8,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (8,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (8,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (9,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (9,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (9,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (10,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (10,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (10,3);
go

-- CP ANEXO 2
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (11,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (11,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (11,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (12,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (12,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (12,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (13,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (13,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (13,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (14,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (14,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (14,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (15,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (15,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (15,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (16,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (16,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (16,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (17,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (17,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (17,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (18,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (18,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (18,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (19,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (19,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (19,3);

insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (20,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (20,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (20,3);
go


--              CONCEPTO INGRESOS
-- CI ANEXO 1 PERIODO 1
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	1);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	4);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	7);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	10);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	13);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	16);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	29);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	22);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	25);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	28);
go 
-- CI ANEXO 1 PERIODO 2
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	2);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	5);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	8);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	11);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	14);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	17);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	20);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	23);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	26);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	29);
go 
-- CI ANEXO 1 PERIODO 3
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	3);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	6);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	9);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	12);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	15);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	18);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	21);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	24);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	27);
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values (20 ,	12 ,	14 ,	28 ,	24 ,	44 ,	30);
go 

--   CONSULTAS

--El sistema busca al empleado por DNI y muestra los siguientes datos: c�digo, nombre, direcci�n, 
--tel�fono, fecha de nacimiento, estado civil (que pueden ser: soltero, casado, conviviente, 
--divorciado, viudo), y grado acad�mico (que pueden ser: primaria, secundaria, bachiller, 
--profesional, magister, doctor).


select * from Empleado
select * from AFP
select * from Contrato
select * from Periodo
select * from Contrato_periodo
select * from pago
select * from CID

--delete pago


--consulta los CID relacionados con el contrato y periodo
SELECT * from CID INNER join Contrato_periodo on Contrato_periodo.id = CID.ID_CONTRATO_PERIODO 
where Contrato_periodo.ID_CONTRATO = 1 AND Contrato_periodo.ID_PERIODO = 3;
--consulta todos los contratos que pueden ser procesados en el periodo activo.@IdPeriodo
select * from Contrato inner join Contrato_periodo on  Contrato.idContrato = Contrato_periodo.ID_CONTRATO inner join Periodo on Periodo.idPeriodo = Contrato_periodo.ID_PERIODO
where Periodo.idPeriodo = 3;
-- update Periodo set estado = 1 where idPeriodo = 3
select * from Periodo where estado = 1 ORDER BY fechaFin;
select * from Periodo
select * from Empleado where idEmpleado = 1
--ActualizarPeriodo @idPeriodo =3,@fechaInicio = '2021-03-16', @fechaFin = '2021-04-15', @estado=1
SELECT * FROM Contrato where ID_EMPLEADO=3 ORDER BY fechaFinal desc
SELECT * FROM Contrato where idContrato=3 ORDER BY fechaFinal desc

update Contrato set  estado= 0 where idContrato = 10
update Periodo set estado = 1 where idPeriodo = 1

--FIN CONSULTAS