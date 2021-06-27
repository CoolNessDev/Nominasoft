�
;X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Contratos\IAfp.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Contratos #
{		 
public

 

	interface

 
IAfp

 
{ 
List 
< 
Afp
> 

ListarAfps 
( 
) 
; 
Afp
BuscarDatosDelAfp_PorNombre
(
string
nombre
)
;
Afp '
BuscarDatosDelAfp_PorCodigo '
(' (
int( +
codigo, 2
)2 3
;3 4
} 
} �
@X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Contratos\IContrato.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Contratos #
{		 
public

 

	interface

 
	IContrato

 
{ 
void 

( 
Contrato #
contrato$ ,
), -
;- .
void
EditarContrato
(
Contrato
contrato
,
int
codigoEmpleado
)
;
void 
AnularContrato
( 
Contrato $
contrato% -
,- .
int/ 2
codigoEmpleado3 A
)A B
;B C
Contrato 
GetContrato 
( 
int  
id! #
)# $
;$ %
Contrato  
MostrarDatosContrato %
(% &
int& )
CodigoEmpleado* 8
)8 9
;9 :
List 
< 
Contrato
> !
GetContratosByPeriodo ,
(, -
Periodo- 4
periodo5 <
)< =
;= >&
ConceptoIngresoDeDescuento "$
GetCIDByContrato_Periodo# ;
(; <
int< ?

idContrato@ J
,J K
intL O
	idPeriodoP Y
)Y Z
;Z [
} 
} �
@X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Contratos\IEmpleado.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Contratos #
{		 
public

 

	interface

 
	IEmpleado

 
{ 
Empleado  
BuscarEmpleadoPorDNI %
(% &
string& ,
DNI- 0
)0 1
;1 2
Empleado
BuscarEmpleado
(
int
id
)
;
List 
< 
Contrato
> 
obtenerContratos '
(' (
int( +

idEmpleado, 6
)6 7
;7 8
} 
} �
>X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Dto\CustomPagoDto.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
Dto 
{ 
public		 

class		 

{

 
public 
int 
Id_empleado 
{  
get  #
;# $
set$ '
;' (
}( )
public 
string 
NombreEmpleado $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
string 
DniEmpleado !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 

TotalHoras !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 
	ValorHora  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
decimal 
SueldoMinimo #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
decimal 

{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
decimal 
TotalDescuentos &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
decimal 

SueldoNeto !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} �
IX:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Servicios\IGestorAccesoDatos.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Servicios #
{		 
public

 

	interface

 
IGestorAccesoDatos

 '
{ 
void 

( 
) 
; 
void
CerrarConexion
(
)
;
void 
IniciarTransaccion
(  
)  !
;! "
void 
TerminarTransaccion
(  !
)! "
;" #
void 
CancelarTransaccion
(  !
)! "
;" #
} 
} �
8X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Pagos\IPago.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Contratos #
{		 
public

 

	interface

 
IPago

 
{ 
bool 
registerPago
( 
Pago 
pago #
)# $
;$ %
List
<
Pago
>
GetPagosByPeriodo
(
Periodo
periodo
)
;
} 
} �
;X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Pagos\IPeriodo.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
Pagos 
{		 
public

 

	interface

 
IPeriodo

 
{ 
Periodo 
GetPeriodoActivo  
(  !
)! "
;" #
bool

(
Periodo
periodo
)
;
bool #
InsertarContratoPeriodo
($ %
int% (

idContrato) 3
,3 4
int5 8
	idPeriodo9 B
)B C
;C D
} 
} �
:X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Entidades\Afp.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Entidades #
{ 
public		 

class		 
Afp		 
{

 
public 
int 
Id_afp 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
Nombre 
{ 
get "
;" #
set$ '
;' (
}) *
public
decimal
Porsentaje_descuento
{
get
;
set
;
}
public 
List 
< 
Contrato 
> 
	Contratos '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
} 
} �
QX:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Entidades\ConceptoIngresoDeDescuento.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Entidades #
{ 
public		 

class		 &
ConceptoIngresoDeDescuento		 +
{

 
public 
int 
Id_cid 
{ 
get 
;  
set! $
;$ %
}& '
public 
decimal 
MontoHorasExtras '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public
decimal
MontoHorasAusente
{
get
;
set
;
}
public 
decimal  
MontoOtrosDescuentos +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
decimal 
MontoPorAdelanto '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
decimal 
MontoOtrosIngresos )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
decimal 
MontoReingreso %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
Periodo 
Periodo 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
Contrato 
Contrato  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
decimal *
CalcularTotalConceptoDescuento 5
(5 6
)6 7
{ 	
return 
MontoHorasAusente $
+% &
MontoPorAdelanto' 7
+8 9 
MontoOtrosDescuentos: N
;N O
} 	
public 
decimal (
CalcularTotalConceptoIngreso 3
(3 4
)4 5
{ 	
return 
MontoHorasExtras #
+$ %
MontoReingreso& 4
+5 6
MontoOtrosIngresos7 I
;I J
} 	
} 
} �0
?X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Entidades\Contrato.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Entidades #
{ 
public		 

class		 
Contrato		 
{

 
public 
int 
Id_contrato 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
bool 
AsignacionFamiliar &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public
string
Cargo
{
get
;
set
;
}
public 
DateTime 
FechaInicio #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
DateTime 
FechaFin  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
int %
HorasContratadasPorSemana ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
int 
	ValorHora 
{ 
get "
;" #
set$ '
;' (
}) *
public 
bool 
Estado 
{ 
get  
;  !
set" %
;% &
}' (
public 
Afp 
Afp 
{ 
get 
; 
set !
;! "
}# $
public 
Empleado 
Empleado  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
Periodo 
Periodo 
{  
get! $
;$ %
set& )
;) *
}+ ,
public &
ConceptoIngresoDeDescuento )&
ConceptoIngresoDeDescuento* D
{E F
getG J
;J K
setL O
;O P
}Q R
public 
bool #
ValidarFechaFinContrato +
(+ ,
), -
{   	
if!! 
(!! 
(!! 
FechaFin!! 
-!! 
FechaInicio!! '
)!!' (
.!!( )
	TotalDays!!) 2
>!!3 4
$num!!5 7
&&!!8 :
(!!; <
FechaFin!!< D
-!!E F
FechaInicio!!G R
)!!R S
.!!S T
	TotalDays!!T ]
<!!^ _
$num!!` c
)!!c d
{"" 
return## 
true## 
;## 
}$$ 
return%% 
false%% 
;%% 
}&& 	
public-- 
bool-- &
ValidarFechaInicioContrato-- .
(--. /
)--/ 0
{.. 	
Contrato// 
anterior// 
=// 
null//  $
;//$ %
try00 
{11 
anterior22 
=22 
Empleado22 #
.22# $
	Contratos22$ -
[22- .
$num22. /
]22/ 0
;220 1
}33 
catch44 
(44 
	Exception44 
)44 
{55 
anterior66 
=66 
null66 
;66  
}77 
if88 
(88 
anterior88 
!=88 
null88  
&&88! #
Id_contrato88$ /
==880 2
anterior883 ;
.88; <
Id_contrato88< G
)88G H
{99 
return:: 
true:: 
;:: 
};; 
if<< 
(<< 
anterior<< 
==<< 
null<<  
||<<! #
FechaInicio<<$ /
><<0 1
anterior<<2 :
.<<: ;
FechaFin<<; C
||<<D F
!<<G H
anterior<<H P
.<<P Q
Estado<<Q W
)<<W X
{== 
return>> 
true>> 
;>> 
}?? 
return@@ 
false@@ 
;@@ 
}AA 	
publicII 
boolII 
ValidarHorasII  
(II  !
)II! "
{JJ 	
ifKK 
(KK 
$numKK 
<=KK %
HorasContratadasPorSemanaKK .
&&KK/ 1%
HorasContratadasPorSemanaKK2 K
<=KKL N
$numKKO Q
&&KKR T%
HorasContratadasPorSemanaKKU n
%KKo p
$numKKq r
==KKs u
$numKKv w
)KKw x
{LL 
returnMM 
trueMM 
;MM 
}NN 
returnOO 
falseOO 
;OO 
}PP 	
publicWW 
boolWW 
ValidarValorHorasWW %
(WW% &
)WW& '
{XX 	
ifYY 
(YY 
$numYY 
<=YY 
	ValorHoraYY 
&&YY  "
	ValorHoraYY# ,
<=YY- /
$numYY0 2
)YY2 3
{ZZ 
return[[ 
true[[ 
;[[ 
}\\ 
return]] 
false]] 
;]] 
}^^ 	
publicdd 
booldd #
ValidarVigenciaContratodd +
(dd+ ,
)dd, -
{ee 	
DateTimeff 
todayff 
=ff 
DateTimeff %
.ff% &
Nowff& )
;ff) *
ifhh 
(hh 
todayhh 
<=hh 
FechaFinhh !
&&hh" $
Estadohh% +
)hh+ ,
{ii 
returnjj 
truejj 
;jj 
}kk 
returnll 
falsell 
;ll 
}mm 	
publictt 
booltt #
ValidarContratoProcesartt +
(tt+ ,
)tt, -
{uu 	
ifxx 
(xx 
FechaFinxx 
>xx 
Periodoxx &
.xx& '
FechaInicioxx' 2
&&xx3 5
Estadoxx6 <
)xx< =
{yy 
returnzz 
truezz 
;zz  
}{{ 
return}} 
false}} 
;}} 
}~~ 	
} 
}�� �
?X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Entidades\Empleado.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Entidades #
{ 
public		 

class		 
Empleado		 
{

 
public 
int 
Id_empleado 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Dni 
{ 
get 
;  
set! $
;$ %
}& '
public
string
EstadoCivil
{
get
;
set
;
}
public 
DateTime 
FechaNacimiento '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
string 
GradoAcademico $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
string 
Nombre 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Telefono 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
	Direccion 
{  !
get" %
;% &
set' *
;* +
}, -
public 
List 
< 
Contrato 
> 
	Contratos '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
} 
} �*
;X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Entidades\Pago.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Entidades #
{ 
public		 

class		 
Pago		 
{

 
public 
int 
Id_pago 
{ 
get  
;  !
set" %
;% &
}' (
public 
DateTime 
FechaActual #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public
decimal
MontoAsignacionFamiliar
{
get
;
set
;
}
public 
decimal 
DescuentAFP "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
decimal 
SueldoMinimo #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
decimal 
PorcentajeDescuento *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
decimal 
	ValorHora  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
decimal 

TotalHoras !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
Periodo 
Periodo 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
Contrato 
Contrato  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
decimal .
"CalcularMontoPorAsignacionFamiliar 9
(9 :
): ;
{ 	
if 
( 
Periodo 
. 
	Contratos !
[! "
$num" #
]# $
.$ %
AsignacionFamiliar% 7
)7 8
{ 
return 
SueldoMinimo #
*$ %
$num& +
;+ ,
} 
return 
$num 
; 
} 	
public!! 
decimal!! "
CalcularDescuentoTotal!! -
(!!- .
)!!. /
{"" 	
if## 
(## 
Contrato## 
.## &
ConceptoIngresoDeDescuento## 3
!=##4 6
null##7 ;
)##; <
{$$ 
return%% 
Convert%% 
.%% 
	ToDecimal%% (
(%%( )
Contrato%%) 1
.%%1 2&
ConceptoIngresoDeDescuento%%2 L
.%%L M*
CalcularTotalConceptoDescuento%%M k
(%%k l
)%%l m
)%%m n
+%%o p!
CalcularDescuentoAFP	%%q �
(
%%� �
)
%%� �
;
%%� �
}&& 
return''  
CalcularDescuentoAFP'' '
(''' (
)''( )
;'') *
}(( 	
public** 
decimal**  
CalcularDescuentoAFP** +
(**+ ,
)**, -
{++ 	
return,,  
CalcularSueldoBasico,, '
(,,' (
),,( )
*,,* +
(,,, -
PorcentajeDescuento,,- @
/,,A B
$num,,C F
),,F G
;,,G H
}-- 	
public00 
decimal00  
CalcularIngresoTotal00 +
(00+ ,
)00, -
{11 	
if22 
(22 
Contrato22 
.22 &
ConceptoIngresoDeDescuento22 3
!=224 6
null227 ;
)22; <
{33 
return44  
CalcularSueldoBasico44 +
(44+ ,
)44, -
+44. /#
MontoAsignacionFamiliar440 G
+44H I
Convert44J Q
.44Q R
	ToDecimal44R [
(44[ \
Contrato44\ d
.44d e&
ConceptoIngresoDeDescuento44e 
.	44 �*
CalcularTotalConceptoIngreso
44� �
(
44� �
)
44� �
)
44� �
;
44� �
}55 
return66  
CalcularSueldoBasico66 '
(66' (
)66( )
+66* +#
MontoAsignacionFamiliar66, C
;66C D
}77 	
public99 
decimal99  
CalcularSueldoBasico99 +
(99+ ,
)99, -
{:: 	
return;; 

TotalHoras;; 
*;; 
	ValorHora;;  )
;;;) *
}<< 	
public>> 
decimal>> 
CalcularSueldoNeto>> )
(>>) *
)>>* +
{?? 	
return@@  
CalcularIngresoTotal@@ '
(@@' (
)@@( )
-@@* +"
CalcularDescuentoTotal@@, B
(@@B C
)@@C D
;@@D E
}AA 	
publicCC 
decimalCC  
CalcularTotalDeHorasCC +
(CC+ ,
)CC, -
{DD 	
returnEE 
PeriodoEE 
.EE "
CalcularSemanasPeriodoEE 1
(EE1 2
)EE2 3
*EE4 5
ContratoEE6 >
.EE> ?%
HorasContratadasPorSemanaEE? X
;EEX Y
}FF 	
}GG 
}HH �
>X:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Entidades\Periodo.cs
	namespace 	
Capa
 
. 

_3_Dominio 
. 
	Entidades #
{ 
public		 

class		 
Periodo		 
{

 
public 
int 

Id_periodo 
{ 
get  #
;# $
set% (
;( )
}* +
public 
DateTime 
FechaInicio #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public
DateTime
FechaFin
{
get
;
set
;
}
public 
bool 
Estado 
{ 
get  
;  !
set" %
;% &
}' (
public 
List 
< 
Contrato 
> 
	Contratos '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public &
ConceptoIngresoDeDescuento )&
ConceptoIngresoDeDescuento* D
{E F
getG J
;J K
setL O
;O P
}Q R
public 
Pago 
Pago 
{ 
get 
; 
set  #
;# $
}% &
public 
int "
CalcularSemanasPeriodo )
() *
)* +
{ 	
TimeSpan 
diferenciaFechas %
=& '
FechaFin( 0
-1 2
FechaInicio3 >
;> ?
int 
dias 
= 
diferenciaFechas '
.' (
Days( ,
;, -
return 
dias 
/ 
$num 
; 
} 	
public   
bool   !
ValidarPeriodoActivos   )
(  ) *
)  * +
{!! 	
DateTime"" 
now"" 
="" 
DateTime"" #
.""# $
Now""$ '
;""' (
if## 
(## 
now## 
>=## 
FechaFin## 
)## 
{$$ 
return%% 
true%% 
;%% 
}&& 
return'' 
false'' 
;'' 
}(( 	
})) 
}** �
DX:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str )
)) *
]* +
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str +
)+ ,
], -
[
assembly
:

AssemblyCopyright
(
$str
)
]
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *�
LX:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Servicios\GestionarLosContratos.cs
	namespace		 	
Capa		
 
.		 

_3_Dominio		 
.		 
	Servicios		 #
{

 
public 

class !
GestionarLosContratos &
{ 
public
bool
ValidarContrato
(
Contrato
contrato
)
{ 	
bool 
estadito 
= 
true  
;  !
if 
( 
! 
contrato 
. #
ValidarFechaFinContrato 1
(1 2
)2 3
)3 4
{ 

MessageBox 
. 
Show 
(  
$str  >
)> ?
;? @
estadito 
= 
false  
;  !
} 
if 
( 
! 
contrato 
. 
ValidarHoras &
(& '
)' (
)( )
{ 

MessageBox 
. 
Show 
(  
$str  N
)N O
;O P
estadito 
= 
false  
;  !
} 
if 
( 
! 
contrato 
. 
ValidarValorHoras *
(* +
)+ ,
), -
{ 

MessageBox 
. 
Show 
(  
$str  =
)= >
;> ?
estadito 
= 
false  
;  !
} 
return   
estadito   
;   
}!! 	
}"" 
}## 