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
--PROCEDURES
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

--El sistema busca al empleado por DNI y muestra los siguientes datos: c�digo, nombre, direcci�n, 
--tel�fono, fecha de nacimiento, estado civil (que pueden ser: soltero, casado, conviviente, 
--divorciado, viudo), y grado acad�mico (que pueden ser: primaria, secundaria, bachiller, 
--profesional, magister, doctor).
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('01234567','av arequipa','soltero','2001-10-29','primaria','044531282','Jorge');
insert into Empleado(dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('76543210','calle cascanueces','casado','20120618 10:34:09 AM','secundaria','989466206','Pedro');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('76543211','urb. pedigree','conviviente','2001-10-29','bachiller','044531282','Juan');
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('76543212','calle los olivos','viudo','2001-10-29','profesional','044531282','Roberto');
go
insert into afp(nombre,porcentajeDeDescuento) values ('HABITAT',13.21);
insert into afp(nombre,porcentajeDeDescuento) values ('INTEGRA',13.29);
insert into afp(nombre,porcentajeDeDescuento) values ('PRIMA',13.34);
insert into afp(nombre,porcentajeDeDescuento) values ('PROFUTURO',13.43);
insert into afp(nombre,porcentajeDeDescuento) values ('PROMEDIO',13.34);
go
InsertarContrato @asignacionFamiliar = true, @cargo = 'Trabajador', @fechaInicial='2021-01-21',@fechaFinal='2021-05-21',@horasContradasPorSemana=16,@valorHora=20,@estado=false,
@ID_AFP=3,@ID_EMPLEADO=1;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'Trabajador', @fechaInicial='2021-02-02',@fechaFinal='2021-07-02',@horasContradasPorSemana=16,@valorHora=20,@estado=true,
@ID_AFP=2,@ID_EMPLEADO=2;
go
insert into Periodo(fechaInicio,fechaFin,estado) values ('2021-04-16','2021-05-15',0);
--Periodo aún activo antes de tiempo actual 2021-06-10 para pruebas
insert into Periodo(fechaInicio,fechaFin,estado) values ('2021-05-16','2021-06-15',1);
insert into Periodo(fechaInicio,fechaFin,estado) values ('2021-03-16','2021-04-15',1);
go
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (1,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (1,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (1,3);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (2,1);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (2,2);
insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (2,3);
go
insert into CID(montoHorasExtras, montoHorasAusente, montoOtrosDescuentos, montoPorAdelanto, montoOtrosIngresos, montoReingreso,ID_CONTRATO_PERIODO)
values
(12,10,13,34,23,56,3);
go
select * from Empleado
select * from AFP
select * from Contrato
select * from Periodo
select * from Contrato_periodo
select * from pago
select * from CID

--consulta los CID relacionados con el contrato y periodo
SELECT * from CID INNER join Contrato_periodo on Contrato_periodo.id = CID.ID_CONTRATO_PERIODO 
where Contrato_periodo.ID_CONTRATO = 1 AND Contrato_periodo.ID_PERIODO = 3;
--consulta todos los contratos que pueden ser procesados en el periodo activo.@IdPeriodo
select * from Contrato inner join Contrato_periodo on  Contrato.idContrato = Contrato_periodo.ID_CONTRATO inner join Periodo on Periodo.idPeriodo = Contrato_periodo.ID_PERIODO
where Periodo.idPeriodo = 3;
-- update Periodo set estado = 1 where idPeriodo = 3
select * from Periodo where estado = 1 ORDER BY fechaFin;
select * from Periodo
select * from Empleado where idEmpleado = 5
select * from Contrato
--ActualizarPeriodo @idPeriodo =3,@fechaInicio = '2021-03-16', @fechaFin = '2021-04-15', @estado=1
SELECT * FROM Contrato where ID_EMPLEADO=5 ORDER BY fechaFinal desc
SELECT * FROM Contrato where idContrato=3 ORDER BY fechaFinal desc

update Contrato set estado = 1 where idContrato = 1

--01234567 1
--76543211 3
--76543212 4
--01234567 5