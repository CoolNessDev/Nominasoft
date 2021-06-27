Ç
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
< 
Afp 
> 

ListarAfps 
( 
) 
; 
Afp '
BuscarDatosDelAfp_PorNombre '
(' (
string( .
nombre/ 5
)5 6
;6 7
Afp '
BuscarDatosDelAfp_PorCodigo '
(' (
int( +
codigo, 2
)2 3
;3 4
} 
} æ
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
CrearContrato 
( 
Contrato #
contrato$ ,
), -
;- .
void 
EditarContrato 
( 
Contrato $
contrato% -
,- .
int/ 2
codigoEmpleado3 A
)A B
;B C
void 
AnularContrato 
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
< 
Contrato 
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
} ô
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
Empleado 
BuscarEmpleado 
(  
int  #
id$ &
)& '
;' (
List 
< 
Contrato 
> 
obtenerContratos '
(' (
int( +

idEmpleado, 6
)6 7
;7 8
} 
} ˆ
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
CustomPagoDto		 
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
}( )
private 
string 
nombreEmpleado %
;% &
private 
string 
dniEmpleado "
;" #
private 
decimal 

totalHoras "
;" #
private 
decimal 
	valorHora !
;! "
private 
decimal 
sueldoMinimo $
;$ %
private 
decimal 
totalIngresos %
;% &
private 
decimal 
totalDescuentos '
;' (
private 
decimal 

sueldoNeto "
;" #
public 
string 
NombreEmpleado $
{% &
get' *
=>+ -
nombreEmpleado. <
;< =
set> A
=>B D
nombreEmpleadoE S
=T U
valueV [
;[ \
}] ^
public 
string 
DniEmpleado !
{" #
get$ '
=>( *
dniEmpleado+ 6
;6 7
set8 ;
=>< >
dniEmpleado? J
=K L
valueM R
;R S
}T U
public 
decimal 

TotalHoras !
{" #
get$ '
=>( *

totalHoras+ 5
;5 6
set7 :
=>; =

totalHoras> H
=I J
valueK P
;P Q
}R S
public 
decimal 
	ValorHora  
{! "
get# &
=>' )
	valorHora* 3
;3 4
set5 8
=>9 ;
	valorHora< E
=F G
valueH M
;M N
}O P
public 
decimal 
SueldoMinimo #
{$ %
get& )
=>* ,
sueldoMinimo- 9
;9 :
set; >
=>? A
sueldoMinimoB N
=O P
valueQ V
;V W
}X Y
public   
decimal   
TotalIngresos   $
{  % &
get  ' *
=>  + -
totalIngresos  . ;
;  ; <
set  = @
=>  A C
totalIngresos  D Q
=  R S
value  T Y
;  Y Z
}  [ \
public!! 
decimal!! 
TotalDescuentos!! &
{!!' (
get!!) ,
=>!!- /
totalDescuentos!!0 ?
;!!? @
set!!A D
=>!!E G
totalDescuentos!!H W
=!!X Y
value!!Z _
;!!_ `
}!!a b
public"" 
decimal"" 

SueldoNeto"" !
{""" #
get""$ '
=>""( *

sueldoNeto""+ 5
;""5 6
set""7 :
=>""; =

sueldoNeto""> H
=""I J
value""K P
;""P Q
}""R S
}$$ 
}%% –
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
AbrirConexion 
( 
) 
; 
void 
CerrarConexion 
( 
) 
; 
void 
IniciarTransaccion 
(  
)  !
;! "
void 
TerminarTransaccion  
(  !
)! "
;" #
void 
CancelarTransaccion  
(  !
)! "
;" #
} 
} Ù
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
registerPago 
( 
Pago 
pago #
)# $
;$ %
List 
< 
Pago 
> 
GetPagosByPeriodo $
($ %
Periodo% ,
periodo- 4
)4 5
;5 6
} 
} Î
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
bool 
UpdatePeriodo 
( 
Periodo "
periodo# *
)* +
;+ ,
bool #
InsertarContratoPeriodo $
($ %
int% (

idContrato) 3
,3 4
int5 8
	idPeriodo9 B
)B C
;C D
} 
} „
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
 
private 
int 
id_afp 
; 
private 
string 
nombre 
; 
private 
decimal  
porsentaje_descuento ,
;, -
private 
List 
< 
Contrato 
> 
	contratos (
;( )
public 
int 
Id_afp 
{ 
get 
=>  "
id_afp# )
;) *
set+ .
=>/ 1
id_afp2 8
=9 :
value; @
;@ A
}B C
public 
string 
Nombre 
{ 
get "
=># %
nombre& ,
;, -
set. 1
=>2 4
nombre5 ;
=< =
value> C
;C D
}E F
public 
decimal  
Porsentaje_descuento +
{, -
get. 1
=>2 4 
porsentaje_descuento5 I
;I J
setK N
=>O Q 
porsentaje_descuentoR f
=g h
valuei n
;n o
}p q
public 
List 
< 
Contrato 
> 
	Contratos '
{( )
get* -
=>. 0
	contratos1 :
;: ;
set< ?
=>@ B
	contratosC L
=M N
valueO T
;T U
}V W
} 
} •!
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
 
private 
int 
id_cid 
; 
private 
decimal 
montoHorasExtras (
;( )
private 
decimal 
montoHorasAusente )
;) *
private 
decimal  
montoOtrosDescuentos ,
;, -
private 
decimal 
montoPorAdelanto (
;( )
private 
decimal 
montoOtrosIngresos *
;* +
private 
decimal 
montoReingreso &
;& '
private 
Periodo 
periodo 
;  
private 
Contrato 
contrato !
;! "
public 
int 
Id_cid 
{ 
get 
=>  "
id_cid# )
;) *
set+ .
=>/ 1
id_cid2 8
=9 :
value; @
;@ A
}B C
public 
decimal 
MontoHorasExtras '
{( )
get* -
=>. 0
montoHorasExtras1 A
;A B
setC F
=>G I
montoHorasExtrasJ Z
=[ \
value] b
;b c
}d e
public 
decimal 
MontoHorasAusente (
{) *
get+ .
=>/ 1
montoHorasAusente2 C
;C D
setE H
=>I K
montoHorasAusenteL ]
=^ _
value` e
;e f
}g h
public 
decimal  
MontoOtrosDescuentos +
{, -
get. 1
=>2 4 
montoOtrosDescuentos5 I
;I J
setK N
=>O Q 
montoOtrosDescuentosR f
=g h
valuei n
;n o
}p q
public 
decimal 
MontoPorAdelanto '
{( )
get* -
=>. 0
montoPorAdelanto1 A
;A B
setC F
=>G I
montoPorAdelantoJ Z
=[ \
value] b
;b c
}d e
public 
decimal 
MontoOtrosIngresos )
{* +
get, /
=>0 2
montoOtrosIngresos3 E
;E F
setG J
=>K M
montoOtrosIngresosN `
=a b
valuec h
;h i
}j k
public 
decimal 
MontoReingreso %
{& '
get( +
=>, .
montoReingreso/ =
;= >
set? B
=>C E
montoReingresoF T
=U V
valueW \
;\ ]
}^ _
public 
Periodo 
Periodo 
{  
get! $
=>% '
periodo( /
;/ 0
set1 4
=>5 7
periodo8 ?
=@ A
valueB G
;G H
}I J
public 
Contrato 
Contrato  
{! "
get# &
=>' )
contrato* 2
;2 3
set4 7
=>8 :
contrato; C
=D E
valueF K
;K L
}M N
public 
decimal *
CalcularTotalConceptoDescuento 5
(5 6
)6 7
{   	
return!! 
MontoHorasAusente!! $
+!!% &
MontoPorAdelanto!!' 7
+!!8 9 
MontoOtrosDescuentos!!: N
;!!N O
}"" 	
public$$ 
decimal$$ (
CalcularTotalConceptoIngreso$$ 3
($$3 4
)$$4 5
{%% 	
return&& 
MontoHorasExtras&& #
+&&$ %
MontoReingreso&&& 4
+&&5 6
MontoOtrosIngresos&&7 I
;&&I J
}'' 	
}(( 
})) ÇE
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
 
private 
int 
id_contrato 
;  
private 
bool 
asignacionFamiliar '
;' (
private 
string 
cargo 
; 
private 
DateTime 
fechaInicio $
;$ %
private 
DateTime 
fechaFin !
;! "
private 
int %
horasContratadasPorSemana -
;- .
private 
int 
	valorHora 
; 
private 
bool 
estado 
; 
private 
Afp 
afp 
; 
private 
Empleado 
empleado !
;! "
private 
Periodo 
periodo 
;  
private &
ConceptoIngresoDeDescuento *&
conceptoIngresoDeDescuento+ E
;E F
public 
int 
Id_contrato 
{  
get! $
=>% '
id_contrato( 3
;3 4
set5 8
=>9 ;
id_contrato< G
=H I
valueJ O
;O P
}Q R
public 
bool 
AsignacionFamiliar &
{' (
get) ,
=>- /
asignacionFamiliar0 B
;B C
setD G
=>H J
asignacionFamiliarK ]
=^ _
value` e
;e f
}g h
public 
string 
Cargo 
{ 
get !
=>" $
cargo% *
;* +
set, /
=>0 2
cargo3 8
=9 :
value; @
;@ A
}B C
public 
DateTime 
FechaInicio #
{$ %
get& )
=>* ,
fechaInicio- 8
;8 9
set: =
=>> @
fechaInicioA L
=M N
valueO T
;T U
}V W
public 
DateTime 
FechaFin  
{! "
get# &
=>' )
fechaFin* 2
;2 3
set4 7
=>8 :
fechaFin; C
=D E
valueF K
;K L
}M N
public 
int %
HorasContratadasPorSemana ,
{- .
get/ 2
=>3 5%
horasContratadasPorSemana6 O
;O P
setQ T
=>U W%
horasContratadasPorSemanaX q
=r s
valuet y
;y z
}{ |
public   
int   
	ValorHora   
{   
get   "
=>  # %
	valorHora  & /
;  / 0
set  1 4
=>  5 7
	valorHora  8 A
=  B C
value  D I
;  I J
}  K L
public!! 
bool!! 
Estado!! 
{!! 
get!!  
=>!!! #
estado!!$ *
;!!* +
set!!, /
=>!!0 2
estado!!3 9
=!!: ;
value!!< A
;!!A B
}!!C D
public## 
Afp## 
Afp## 
{## 
get## 
=>## 
afp##  #
;### $
set##% (
=>##) +
afp##, /
=##0 1
value##2 7
;##7 8
}##9 :
public$$ 
Empleado$$ 
Empleado$$  
{$$! "
get$$# &
=>$$' )
empleado$$* 2
;$$2 3
set$$4 7
=>$$8 :
empleado$$; C
=$$D E
value$$F K
;$$K L
}$$M N
public%% 
Periodo%% 
Periodo%% 
{%%  
get%%! $
=>%%% '
periodo%%( /
;%%/ 0
set%%1 4
=>%%5 7
periodo%%8 ?
=%%@ A
value%%B G
;%%G H
}%%I J
public&& &
ConceptoIngresoDeDescuento&& )&
ConceptoIngresoDeDescuento&&* D
{&&E F
get&&G J
=>&&K M&
conceptoIngresoDeDescuento&&N h
;&&h i
set&&j m
=>&&n p'
conceptoIngresoDeDescuento	&&q ‹
=
&&Œ 
value
&&Ž “
;
&&“ ”
}
&&• –
public// 
bool// #
ValidarFechaFinContrato// +
(//+ ,
)//, -
{00 	
if11 
(11 
(11 
FechaFin11 
-11 
FechaInicio11 '
)11' (
.11( )
	TotalDays11) 2
>113 4
$num115 7
&&118 :
(11; <
FechaFin11< D
-11E F
FechaInicio11G R
)11R S
.11S T
	TotalDays11T ]
<11^ _
$num11` c
)11c d
{22 
return33 
true33 
;33 
}44 
return55 
false55 
;55 
}66 	
public== 
bool== &
ValidarFechaInicioContrato== .
(==. /
)==/ 0
{>> 	
Contrato?? 
anterior?? 
=?? 
null??  $
;??$ %
try@@ 
{AA 
anteriorBB 
=BB 
EmpleadoBB #
.BB# $
	ContratosBB$ -
[BB- .
$numBB. /
]BB/ 0
;BB0 1
}CC 
catchDD 
(DD 
	ExceptionDD 
)DD 
{EE 
anteriorFF 
=FF 
nullFF 
;FF  
}GG 
ifHH 
(HH 
anteriorHH 
!=HH 
nullHH  
&&HH! #
Id_contratoHH$ /
==HH0 2
anteriorHH3 ;
.HH; <
id_contratoHH< G
)HHG H
{II 
returnJJ 
trueJJ 
;JJ 
}KK 
ifLL 
(LL 
anteriorLL 
==LL 
nullLL  
||LL! #
FechaInicioLL$ /
>LL0 1
anteriorLL2 :
.LL: ;
FechaFinLL; C
||LLD F
!LLG H
anteriorLLH P
.LLP Q
estadoLLQ W
)LLW X
{MM 
returnNN 
trueNN 
;NN 
}OO 
returnPP 
falsePP 
;PP 
}QQ 	
publicYY 
boolYY 
ValidarHorasYY  
(YY  !
)YY! "
{ZZ 	
if[[ 
([[ 
$num[[ 
<=[[ %
HorasContratadasPorSemana[[ .
&&[[/ 1%
HorasContratadasPorSemana[[2 K
<=[[L N
$num[[O Q
&&[[R T%
HorasContratadasPorSemana[[U n
%[[o p
$num[[q r
==[[s u
$num[[v w
)[[w x
{\\ 
return]] 
true]] 
;]] 
}^^ 
return__ 
false__ 
;__ 
}`` 	
publicgg 
boolgg 
ValidarValorHorasgg %
(gg% &
)gg& '
{hh 	
ifii 
(ii 
$numii 
<=ii 
	ValorHoraii 
&&ii  "
	ValorHoraii# ,
<=ii- /
$numii0 2
&&ii3 5
	ValorHoraii6 ?
-ii@ A
(iiB C
intiiC F
)iiF G
	ValorHoraiiG P
==iiQ S
$numiiT U
)iiU V
{jj 
returnkk 
truekk 
;kk 
}ll 
returnmm 
falsemm 
;mm 
}nn 	
publictt 
booltt #
ValidarVigenciaContratott +
(tt+ ,
)tt, -
{uu 	
DateTimevv 
todayvv 
=vv 
DateTimevv %
.vv% &
Nowvv& )
;vv) *
ifxx 
(xx 
todayxx 
<=xx 
FechaFinxx !
&&xx" $
Estadoxx% +
==xx, .
truexx/ 3
)xx3 4
{yy 
returnzz 
truezz 
;zz 
}{{ 
return|| 
false|| 
;|| 
}}} 	
public
„„ 
bool
„„ %
ValidarContratoProcesar
„„ +
(
„„+ ,
)
„„, -
{
…… 	
if
ˆˆ 
(
ˆˆ 
FechaFin
ˆˆ 
>
ˆˆ 
Periodo
ˆˆ &
.
ˆˆ& '
FechaInicio
ˆˆ' 2
&&
ˆˆ3 5
Estado
ˆˆ6 <
)
ˆˆ< =
{
‰‰ 
return
ŠŠ 
true
ŠŠ 
;
ŠŠ  
}
‹‹ 
return
 
false
 
;
 
}
ŽŽ 	
}
 
} Ü
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
 
private 
int 
id_empleado 
;  
private 
string 
dni 
; 
private 
string 
	direccion  
;  !
private 
string 
estadoCivil "
;" #
private 
DateTime 
fechaNacimiento (
;( )
private 
string 
gradoAcademico %
;% &
private 
string 
telefono 
;  
private 
string 
nombre 
; 
private 
List 
< 
Contrato 
> 
	contratos (
;( )
public 
int 
Id_empleado 
{  
get! $
=>% '
id_empleado( 3
;3 4
set5 8
=>9 ;
id_empleado< G
=H I
valueJ O
;O P
}Q R
public 
string 
Dni 
{ 
get 
=>  "
dni# &
;& '
set( +
=>, .
dni/ 2
=3 4
value5 :
;: ;
}< =
public 
string 
EstadoCivil !
{" #
get$ '
=>( *
estadoCivil+ 6
;6 7
set8 ;
=>< >
estadoCivil? J
=K L
valueM R
;R S
}T U
public 
DateTime 
FechaNacimiento '
{( )
get* -
=>. 0
fechaNacimiento1 @
;@ A
setB E
=>F H
fechaNacimientoI X
=Y Z
value[ `
;` a
}b c
public 
string 
GradoAcademico $
{% &
get' *
=>+ -
gradoAcademico. <
;< =
set> A
=>B D
gradoAcademicoE S
=T U
valueV [
;[ \
}] ^
public 
string 
Nombre 
{ 
get "
=># %
nombre& ,
;, -
set. 1
=>2 4
nombre5 ;
=< =
value> C
;C D
}E F
public 
string 
Telefono 
{  
get! $
=>% '
telefono( 0
;0 1
set2 5
=>6 8
telefono9 A
=B C
valueD I
;I J
}K L
public 
string 
	Direccion 
{  !
get" %
=>& (
	direccion) 2
;2 3
set4 7
=>8 :
	direccion; D
=E F
valueG L
;L M
}N O
public 
List 
< 
Contrato 
> 
	Contratos '
{( )
get* -
=>. 0
	contratos1 :
;: ;
set< ?
=>@ B
	contratosC L
=M N
valueO T
;T U
}V W
}"" 
}## Ï9
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
 
private 
int 
id_pago 
; 
private 
DateTime 
fechaActual $
;$ %
private 
decimal #
montoAsignacionFamiliar /
;/ 0
private 
decimal 
descuentAFP #
;# $
private 
decimal 
sueldoMinimo $
;$ %
private 
decimal 
porcentajeDescuento +
;+ ,
private 
decimal 
	valorHora !
;! "
private 
decimal 

totalHoras "
;" #
private 
Periodo 
periodo 
;  
private 
Contrato 
contrato !
;! "
public 
int 
Id_pago 
{ 
get  
=>! #
id_pago$ +
;+ ,
set- 0
=>1 3
id_pago4 ;
=< =
value> C
;C D
}E F
public 
DateTime 
FechaActual #
{$ %
get& )
=>* ,
fechaActual- 8
;8 9
set: =
=>> @
fechaActualA L
=M N
valueO T
;T U
}V W
public 
decimal #
MontoAsignacionFamiliar .
{/ 0
get1 4
=>5 7#
montoAsignacionFamiliar8 O
;O P
setQ T
=>U W#
montoAsignacionFamiliarX o
=p q
valuer w
;w x
}y z
public 
decimal 
DescuentAFP "
{# $
get% (
=>) +
descuentAFP, 7
;7 8
set9 <
=>= ?
descuentAFP@ K
=L M
valueN S
;S T
}U V
public 
decimal 
SueldoMinimo #
{$ %
get& )
=>* ,
sueldoMinimo- 9
;9 :
set; >
=>? A
sueldoMinimoB N
=O P
valueQ V
;V W
}X Y
public 
decimal 
PorcentajeDescuento *
{+ ,
get- 0
=>1 3
porcentajeDescuento4 G
;G H
setI L
=>M O
porcentajeDescuentoP c
=d e
valuef k
;k l
}m n
public 
decimal 
	ValorHora  
{! "
get# &
=>' )
	valorHora* 3
;3 4
set5 8
=>9 ;
	valorHora< E
=F G
valueH M
;M N
}O P
public 
decimal 

TotalHoras !
{" #
get$ '
=>( *

totalHoras+ 5
;5 6
set7 :
=>; =

totalHoras> H
=I J
valueK P
;P Q
}R S
public 
Periodo 
Periodo 
{  
get! $
=>% '
periodo( /
;/ 0
set1 4
=>5 7
periodo8 ?
=@ A
valueB G
;G H
}I J
public 
Contrato 
Contrato  
{! "
get# &
=>' )
contrato* 2
;2 3
set4 7
=>8 :
contrato; C
=D E
valueF K
;K L
}M N
public"" 
decimal"" .
"CalcularMontoPorAsignacionFamiliar"" 9
(""9 :
)"": ;
{## 	
if$$ 
($$ 
Periodo$$ 
.$$ 
	Contratos$$ !
[$$! "
$num$$" #
]$$# $
.$$$ %
AsignacionFamiliar$$% 7
)$$7 8
{%% 
return&& 
SueldoMinimo&& #
*&&$ %
$num&&& +
;&&+ ,
}'' 
return(( 
$num(( 
;(( 
})) 	
public++ 
decimal++ "
CalcularDescuentoTotal++ -
(++- .
)++. /
{,, 	
if-- 
(-- 
Contrato-- 
.-- &
ConceptoIngresoDeDescuento-- 3
!=--4 6
null--7 ;
)--; <
{.. 
return// 
Convert// 
.// 
	ToDecimal// (
(//( )
Contrato//) 1
.//1 2&
ConceptoIngresoDeDescuento//2 L
.//L M*
CalcularTotalConceptoDescuento//M k
(//k l
)//l m
)//m n
+//o p!
CalcularDescuentoAFP	//q …
(
//… †
)
//† ‡
;
//‡ ˆ
}00 
return11  
CalcularDescuentoAFP11 '
(11' (
)11( )
;11) *
}22 	
public44 
decimal44  
CalcularDescuentoAFP44 +
(44+ ,
)44, -
{55 	
return66  
CalcularSueldoBasico66 '
(66' (
)66( )
*66* +
(66, -
PorcentajeDescuento66- @
/66A B
$num66C F
)66F G
;66G H
}77 	
public:: 
decimal::  
CalcularIngresoTotal:: +
(::+ ,
)::, -
{;; 	
if<< 
(<< 
Contrato<< 
.<< &
ConceptoIngresoDeDescuento<< 3
!=<<4 6
null<<7 ;
)<<; <
{== 
return>>  
CalcularSueldoBasico>> +
(>>+ ,
)>>, -
+>>. /#
MontoAsignacionFamiliar>>0 G
+>>H I
Convert>>J Q
.>>Q R
	ToDecimal>>R [
(>>[ \
Contrato>>\ d
.>>d e&
ConceptoIngresoDeDescuento>>e 
.	>> €*
CalcularTotalConceptoIngreso
>>€ œ
(
>>œ 
)
>> ž
)
>>ž Ÿ
;
>>Ÿ  
}?? 
return@@  
CalcularSueldoBasico@@ '
(@@' (
)@@( )
+@@* +#
MontoAsignacionFamiliar@@, C
;@@C D
}AA 	
publicCC 
decimalCC  
CalcularSueldoBasicoCC +
(CC+ ,
)CC, -
{DD 	
returnEE 

TotalHorasEE 
*EE 
	ValorHoraEE  )
;EE) *
}FF 	
publicHH 
decimalHH 
CalcularSueldoNetoHH )
(HH) *
)HH* +
{II 	
returnJJ  
CalcularIngresoTotalJJ '
(JJ' (
)JJ( )
-JJ* +"
CalcularDescuentoTotalJJ, B
(JJB C
)JJC D
;JJD E
}KK 	
publicMM 
decimalMM  
CalcularTotalDeHorasMM +
(MM+ ,
)MM, -
{NN 	
returnOO 
PeriodoOO 
.OO "
CalcularSemanasPeriodoOO 1
(OO1 2
)OO2 3
*OO4 5
ContratoOO6 >
.OO> ?%
HorasContratadasPorSemanaOO? X
;OOX Y
}PP 	
}QQ 
}RR À
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
 
private 
int 

id_periodo 
; 
private 
DateTime 
fechaInicio $
;$ %
private 
DateTime 
fechaFin !
;! "
private 
bool 
estado 
; 
private 
List 
< 
Contrato 
> 
	contratos (
;( )
private &
ConceptoIngresoDeDescuento *&
conceptoIngresoDeDescuento+ E
;E F
private 
Pago 
pago 
; 
public 
int 

Id_periodo 
{ 
get  #
=>$ &

id_periodo' 1
;1 2
set3 6
=>7 9

id_periodo: D
=E F
valueG L
;L M
}N O
public 
DateTime 
FechaInicio #
{$ %
get& )
=>* ,
fechaInicio- 8
;8 9
set: =
=>> @
fechaInicioA L
=M N
valueO T
;T U
}V W
public 
DateTime 
FechaFin  
{! "
get# &
=>' )
fechaFin* 2
;2 3
set4 7
=>8 :
fechaFin; C
=D E
valueF K
;K L
}M N
public 
bool 
Estado 
{ 
get  
=>! #
estado$ *
;* +
set, /
=>0 2
estado3 9
=: ;
value< A
;A B
}C D
public 
List 
< 
Contrato 
> 
	Contratos '
{( )
get* -
=>. 0
	contratos1 :
;: ;
set< ?
=>@ B
	contratosC L
=M N
valueO T
;T U
}V W
public &
ConceptoIngresoDeDescuento )&
ConceptoIngresoDeDescuento* D
{E F
getG J
=>K M&
conceptoIngresoDeDescuentoN h
;h i
setj m
=>n p'
conceptoIngresoDeDescuento	q ‹
=
Œ 
value
Ž “
;
“ ”
}
• –
public 
Pago 
Pago 
{ 
get 
=> !
pago" &
;& '
set( +
=>, .
pago/ 3
=4 5
value6 ;
;; <
}= >
public 
int "
CalcularSemanasPeriodo )
() *
)* +
{ 	
TimeSpan 
diferenciaFechas %
=& '
FechaFin( 0
-1 2
FechaInicio3 >
;> ?
int 
dias 
= 
diferenciaFechas '
.' (
Days( ,
;, -
return 
dias 
/ 
$num 
; 
}   	
public(( 
bool(( !
ValidarPeriodoActivos(( )
((() *
)((* +
{)) 	
DateTime** 
now** 
=** 
DateTime** #
.**# $
Now**$ '
;**' (
if++ 
(++ 
now++ 
>=++ 
FechaFin++ 
)++ 
{,, 
return-- 
true-- 
;-- 
}.. 
return// 
false// 
;// 
}00 	
}11 
}22 ï
DX:\Virtuales\Calidad\SOWAD\Capa.3_Dominio\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
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
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
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
]$$) *õ
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
public 
bool 
ValidarContrato #
(# $
Contrato$ ,
contrato- 5
)5 6
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
{ 

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
} 
if 
( 
! 
contrato 
. 
ValidarHoras &
(& '
)' (
)( )
{ 

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
} 
if 
( 
! 
contrato 
. 
ValidarValorHoras *
(* +
)+ ,
), -
{ 

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
} 
return   
estadito   
;   
}!! 	
}"" 
}## 