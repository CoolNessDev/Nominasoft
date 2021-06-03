create database nominasoft
use nominasoft
CREATE TABLE Empleado(
	idEmpleado int IDENTITY(1,1) constraint PK_IDEMPLEADO primary key,
	dni int,
	direccion varchar(50),
	estadoCivil varchar(30),
	fechaNacimiento date,
	GradoAcademico varchar(30),
	telefono int,
	nombre varchar(50)
);

CREATE TABLE AFP(
	idAfp int IDENTITY(1,1) constraint PK_IDAFP primary key,
	nombre varchar(50),
	porcentajeDeDescuento decimal(18,2)
);
CREATE TABLE Contrato(
	idContrato int IDENTITY(1,1) constraint PK_IDCONTRATO primary key,
	asignacionFamiliar decimal(18,2),
	cargo varchar(30),
	fechaInicial dateTime,
	fechaFinal datetime,
	horasContradasPorSemana int,
	valorHora int,
	estado bit,
	-----------------------------------------------------------------------
	ID_AFP int constraint FK_CONTRATO_AFP foreign key references AFP(idAfp),
	ID_EMPLEADO int constraint FK_CONTRATO_EMPLEADO foreign key references Empleado(idEmpleado)
);

CREATE TABLE Periodo(
	idPeriodo int IDENTITY(1,1) constraint PK_IDPeriodo primary key,
	fechaInicio datetime,
	fechaFin datetime,
	estado bit
);

CREATE TABLE CID(
	idCID int IDENTITY(1,1) constraint PK_IDCID primary key,
	montoHorasExtras decimal(18,2),
    montoHorasAusente decimal(18,2),
    montoOtrosDescuentos decimal(18,2),
    montoPorAdelanto decimal(18,2),
    montoOtrosIngresos decimal(18,2),
    montoReingreso decimal(18,2),
	-----------------------------------------------------------------------
	ID_CONTRATO int constraint FK_CID_CONTRATO foreign key references Contrato(idContrato), 
	ID_PERIODO int  constraint FK_CID_PERIODO foreign key references Periodo(idPeriodo)
);

CREATE TABLE Pago(
	idPago int IDENTITY(1,1) constraint PK_IDPAGO primary key,
	fechaActual datetime,
	montoAsignacionAFP decimal(18,2),
	descuentoAFP decimal(18,2),
	sueldoMinimo decimal(18,2),
	porsentajeDescuento decimal(18,2),
	valorHora decimal(18,2),
	totalHora decimal(18,2),
	-----------------------------------------------------------------------
	ID_CID int  constraint FK_PAGO_CID foreign key references CID(idCID),
	ID_PERIODO int  constraint FK_PAGO_PERIODO foreign key references Periodo(idPeriodo),
	ID_CONTRATO int constraint FK_PAGO_CONTRATO foreign key references Contrato(idContrato)
);
go
alter table Contrato alter column asignacionFamiliar bit
alter table Empleado alter column dni varchar(8)
alter table Empleado alter column telefono varchar(15)
GO
CREATE PROCEDURE [dbo].[spInsertaPago] 
(
@fechaActual datetime,
@montoAsignacionAFP decimal(18,2),
@descuentoAFP decimal(18,2),
@sueldoMinimo decimal(18,2),
@porsentajeDescuento decimal(18,2),
@valorHora decimal(18,2),
@totalHora decimal(18,2),
@ID_CID int,
@ID_PERIODO int,
@ID_CONTRATO int
)
as
begin 
	insert into Pago(fechaActual, montoAsignacionAFP,descuentoAFP,sueldoMinimo,porsentajeDescuento,valorHora, totalHora,ID_CID,ID_PERIODO,ID_CONTRATO) values
	(@fechaActual,@montoAsignacionAFP, @descuentoAFP,@sueldoMinimo,@porsentajeDescuento,@valorHora,@totalHora,@ID_CID,@ID_PERIODO,@ID_CONTRATO)
end
go

spInsertaPago @fechaActual = '20120618 10:34:09 AM', @montoAsignacionAFP = 20, @descuentoAFP=10,@sueldoMinimo=10,@porsentajeDescuento=10,@valorHora=10,@totalHora=10,
@ID_CID=null,@ID_PERIODO=null,@ID_CONTRATO=null;

GO
insert into Pago (fechaActual, montoAsignacionAFP,descuentoAFP,sueldoMinimo,porsentajeDescuento,valorHora, totalHora,ID_CID,ID_PERIODO,ID_CONTRATO) 
values
('20120618 10:34:09 AM', 20,10,10,10,10, 10,null,null,null)
go
create procedure InsertarContrato
(
	@asignacionFamiliar bit,
	@cargo varchar(30),
	@fechaInicial dateTime,
	@fechaFinal datetime,
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
--delete from Contrato
insert into afp(nombre,porcentajeDeDescuento) values ('Prima',0.18)
insert into afp(nombre,porcentajeDeDescuento) values ('Integra',0.17)
select * from afp
insert into Empleado (dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('03789456','address','Soltero','2001-10-29','Grado academico','044531282','Jorge')
insert into Empleado(dni,direccion,estadoCivil,fechaNacimiento,GradoAcademico,telefono,nombre) values ('01234567','asda','soltero','20120618 10:34:09 AM','asd','989466206','Pedro')
select * from Empleado
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'cargo22', @fechaInicial='20210418 10:34:09 AM',@fechaFinal='20210518 10:34:09 AM',@horasContradasPorSemana=16,@valorHora=20,@estado=true,
@ID_AFP=2,@ID_EMPLEADO=4;
go
InsertarContrato @asignacionFamiliar = false, @cargo = 'cargo3', @fechaInicial='20210518 10:34:09 AM',@fechaFinal='20210618 10:34:09 AM',@horasContradasPorSemana=16,@valorHora=20,@estado=true,
@ID_AFP=3,@ID_EMPLEADO=5;
go
--delete from contrato
--delete from Empleado

select * from contrato



select * from Contrato where ID_EMPLEADO=1 and estado =1 Order by fechaFinal desc

select * from Empleado

