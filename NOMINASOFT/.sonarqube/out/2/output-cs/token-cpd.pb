ê
7X:\Virtuales\Calidad\SOWAD\Capa.2_Aplicacion\AFPTest.cs
	namespace 	"
NOMINASOFT_ConsolaTest
  
.  !
Test_Entidad! -
{		 
[

 
	TestClass

 
]

 
public 

class 
AFPTest 
{ 
[ 	

TestMethod	 
] 
public 
void 
	ListarAFP 
( 
) 
{ 	
GestionarContratos 
servicio '
=( )
new* -
GestionarContratos. @
(@ A
)A B
;B C
List 
< 
Afp 
> 
listaAfp 
=  
servicio! )
.) *
llenarComboBoxAFP* ;
(; <
)< =
;= >
Assert 
. 
	IsNotNull 
( 
listaAfp %
)% &
;& '
} 	
} 
} ò
GX:\Virtuales\Calidad\SOWAD\Capa.2_Aplicacion\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str ,
), -
]- .
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
$str .
). /
]/ 0
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
]$$) *úD
LX:\Virtuales\Calidad\SOWAD\Capa.2_Aplicacion\Servicios\GestionarContratos.cs
	namespace 	
Capa
 
. 
_2_Aplicacion 
. 
	Servicios &
{ 
public 

class 
GestionarContratos #
{ 
private 
readonly 
IGestorAccesoDatos +
gestorAccesoDatos, =
;= >
private 
readonly 
	IEmpleado "
empleadoDAO# .
;. /
private 
readonly 
IAfp 
afpDAO $
;$ %
private 
readonly 
	IContrato "
contratoDAO# .
;. /
private 
readonly 
IPeriodo !

periodoDAO" ,
;, -
public 
GestionarContratos !
(! "
)" #
{ 	
FabricaAbstracta 
fabricaAbstracta .
=/ 0
FabricaAbstracta1 A
.A B
crearInstanciaB P
(P Q
)Q R
;R S
gestorAccesoDatos 
= 
fabricaAbstracta  0
.0 1"
crearGestorAccesoDatos1 G
(G H
)H I
;I J
empleadoDAO 
= 
fabricaAbstracta *
.* +
crearEmpleadoDAO+ ;
(; <
gestorAccesoDatos< M
)M N
;N O
afpDAO 
= 
fabricaAbstracta %
.% &
crearAfpDAO& 1
(1 2
gestorAccesoDatos2 C
)C D
;D E
contratoDAO 
= 
fabricaAbstracta *
.* +
crearContratoDAO+ ;
(; <
gestorAccesoDatos< M
)M N
;N O

periodoDAO 
= 
fabricaAbstracta )
.) *
crearPeriodoDAO* 9
(9 :
gestorAccesoDatos: K
)K L
;L M
} 	
public 
Periodo 
GetPeriodoActivo '
(' (
)( )
{   	
gestorAccesoDatos!! 
.!! 
AbrirConexion!! +
(!!+ ,
)!!, -
;!!- .
Periodo"" 
periodo"" 
="" 

periodoDAO"" (
.""( )
GetPeriodoActivo"") 9
(""9 :
)"": ;
;""; <
gestorAccesoDatos## 
.## 
CerrarConexion## ,
(##, -
)##- .
;##. /
return$$ 
periodo$$ 
;$$ 
}%% 	
public&& 
bool&& #
InsertarContratoPeriodo&& +
(&&+ ,
int&&, /

idContrato&&0 :
,&&: ;
int&&< ?
	idPeriodo&&@ I
)&&I J
{'' 	
gestorAccesoDatos(( 
.(( 
AbrirConexion(( +
(((+ ,
)((, -
;((- .
bool)) 
insert)) 
=)) 

periodoDAO)) $
.))$ %#
InsertarContratoPeriodo))% <
())< =

idContrato))= G
,))G H
	idPeriodo))I R
)))R S
;))S T
gestorAccesoDatos** 
.** 
CerrarConexion** ,
(**, -
)**- .
;**. /
return++ 
insert++ 
;++ 
},, 	
public.. 
Empleado.. 
BuscarEmpleado.. &
(..& '
string..' -
dni... 1
)..1 2
{// 	
gestorAccesoDatos00 
.00 
AbrirConexion00 +
(00+ ,
)00, -
;00- .
Empleado11 
empleado11 
=11 
empleadoDAO11  +
.11+ , 
BuscarEmpleadoPorDNI11, @
(11@ A
dni11A D
)11D E
;11E F
if22 
(22 
empleado22 
!=22 
null22  
)22  !
{33 
empleado44 
.44 
	Contratos44 "
=44# $
empleadoDAO44% 0
.440 1
obtenerContratos441 A
(44A B
empleado44B J
.44J K
Id_empleado44K V
)44V W
;44W X
}55 
return66 
empleado66 
;66 
}77 	
public99 
List99 
<99 
Afp99 
>99 
llenarComboBoxAFP99 *
(99* +
)99+ ,
{:: 	
gestorAccesoDatos;; 
.;; 
AbrirConexion;; +
(;;+ ,
);;, -
;;;- .
List<< 
<<< 
Afp<< 
><< 
	listarAfp<< 
=<<  !
afpDAO<<" (
.<<( )

ListarAfps<<) 3
(<<3 4
)<<4 5
;<<5 6
gestorAccesoDatos== 
.== 
CerrarConexion== ,
(==, -
)==- .
;==. /
return>> 
	listarAfp>> 
;>> 
}?? 	
publicBB 
AfpBB 
	BuscarAFPBB 
(BB 
stringBB #
AFPBB$ '
)BB' (
{CC 	
gestorAccesoDatosDD 
.DD 
AbrirConexionDD +
(DD+ ,
)DD, -
;DD- .
AfpEE 
afpEE 
=EE 
afpDAOEE 
.EE '
BuscarDatosDelAfp_PorNombreEE 8
(EE8 9
AFPEE9 <
)EE< =
;EE= >
gestorAccesoDatosFF 
.FF 
CerrarConexionFF ,
(FF, -
)FF- .
;FF. /
returnGG 
afpGG 
;GG 
}HH 	
publicJJ 
AfpJJ 
BuscarAFPCodigoJJ "
(JJ" #
intJJ# &
codigoJJ' -
)JJ- .
{KK 	
gestorAccesoDatosLL 
.LL 
AbrirConexionLL +
(LL+ ,
)LL, -
;LL- .
AfpMM 
afpMM 
=MM 
afpDAOMM 
.MM '
BuscarDatosDelAfp_PorCodigoMM 8
(MM8 9
codigoMM9 ?
)MM? @
;MM@ A
gestorAccesoDatosNN 
.NN 
CerrarConexionNN ,
(NN, -
)NN- .
;NN. /
returnOO 
afpOO 
;OO 
}PP 	
publicRR 
voidRR 
GuardarContratosRR $
(RR$ %
ContratoRR% -
contratoRR. 6
)RR6 7
{SS 	
gestorAccesoDatosTT 
.TT 
AbrirConexionTT +
(TT+ ,
)TT, -
;TT- .
contratoDAOUU 
.UU 
CrearContratoUU %
(UU% &
contratoUU& .
)UU. /
;UU/ 0
gestorAccesoDatosVV 
.VV 
CerrarConexionVV ,
(VV, -
)VV- .
;VV. /
}WW 	
publicYY 
ContratoYY 
MostrarContratosYY (
(YY( )
intYY) ,
codigoEmpleadoYY- ;
)YY; <
{ZZ 	
gestorAccesoDatos[[ 
.[[ 
AbrirConexion[[ +
([[+ ,
)[[, -
;[[- .
Contrato\\ 
contrato\\ 
=\\ 
contratoDAO\\  +
.\\+ , 
MostrarDatosContrato\\, @
(\\@ A
codigoEmpleado\\A O
)\\O P
;\\P Q
gestorAccesoDatos]] 
.]] 
CerrarConexion]] ,
(]], -
)]]- .
;]]. /
return^^ 
contrato^^ 
;^^ 
}__ 	
public`` 
void`` 
EditarContratos`` #
(``# $
Contrato``$ ,
contrato``- 5
,``5 6
int``7 :
codigoEmpleado``; I
)``I J
{aa 	
gestorAccesoDatosbb 
.bb 
AbrirConexionbb +
(bb+ ,
)bb, -
;bb- .
contratoDAOcc 
.cc 
EditarContratocc &
(cc& '
contratocc' /
,cc/ 0
codigoEmpleadocc1 ?
)cc? @
;cc@ A
gestorAccesoDatosdd 
.dd 
CerrarConexiondd ,
(dd, -
)dd- .
;dd. /
}ee 	
publicgg 
voidgg 
AnularContratosgg #
(gg# $
Contratogg$ ,
contratogg- 5
,gg5 6
intgg7 :
codigoEmpleadogg; I
)ggI J
{hh 	
gestorAccesoDatosii 
.ii 
AbrirConexionii +
(ii+ ,
)ii, -
;ii- .
contratoDAOjj 
.jj 
AnularContratojj &
(jj& '
contratojj' /
,jj/ 0
codigoEmpleadojj1 ?
)jj? @
;jj@ A
gestorAccesoDatoskk 
.kk 
CerrarConexionkk ,
(kk, -
)kk- .
;kk. /
}ll 	
}mm 
}nn ÿ:
HX:\Virtuales\Calidad\SOWAD\Capa.2_Aplicacion\Servicios\GestionarPagos.cs
	namespace 	
Capa
 
. 
_2_Aplicacion 
. 
	Servicios &
{ 
public 

class 
GestionarPagos 
{ 
private 
readonly 
IGestorAccesoDatos +
gestorAccesoDatos, =
;= >
private 
readonly 
IPeriodo !

periodoDAO" ,
;, -
private 
readonly 
	IContrato "
contratoDAO# .
;. /
private 
readonly 
IPago 
pagoDAO &
;& '
private 
readonly 
	IEmpleado "
empleadoDAO# .
;. /
public 
GestionarPagos 
( 
) 
{ 	
FabricaAbstracta 
fabricaAbstracta -
=. /
FabricaAbstracta0 @
.@ A
crearInstanciaA O
(O P
)P Q
;Q R
gestorAccesoDatos 
= 
fabricaAbstracta  0
.0 1"
crearGestorAccesoDatos1 G
(G H
)H I
;I J

periodoDAO 
= 
fabricaAbstracta )
.) *
crearPeriodoDAO* 9
(9 :
gestorAccesoDatos: K
)K L
;L M
contratoDAO 
= 
fabricaAbstracta *
.* +
crearContratoDAO+ ;
(; <
gestorAccesoDatos< M
)M N
;N O
pagoDAO 
= 
fabricaAbstracta &
.& '
crearPagoDAO' 3
(3 4
gestorAccesoDatos4 E
)E F
;F G
empleadoDAO   
=   
fabricaAbstracta   *
.  * +
crearEmpleadoDAO  + ;
(  ; <
gestorAccesoDatos  < M
)  M N
;  N O
}!! 	
public"" 
Periodo"" 
GetPeriodoActivo"" '
(""' (
)""( )
{## 	
gestorAccesoDatos$$ 
.$$ 
AbrirConexion$$ +
($$+ ,
)$$, -
;$$- .
Periodo%% 
periodo%% 
=%% 

periodoDAO%% (
.%%( )
GetPeriodoActivo%%) 9
(%%9 :
)%%: ;
;%%; <
gestorAccesoDatos&& 
.&& 
CerrarConexion&& ,
(&&, -
)&&- .
;&&. /
return'' 
periodo'' 
;'' 
}(( 	
public)) 
bool)) 
updatePeriodo)) !
())! "
Periodo))" )
periodo))* 1
)))1 2
{** 	
gestorAccesoDatos++ 
.++ 
AbrirConexion++ +
(+++ ,
)++, -
;++- .
bool,, 
update,, 
=,, 

periodoDAO,, $
.,,$ %
UpdatePeriodo,,% 2
(,,2 3
periodo,,3 :
),,: ;
;,,; <
gestorAccesoDatos-- 
.-- 
CerrarConexion-- ,
(--, -
)--- .
;--. /
return.. 
update.. 
;.. 
}// 	
public00 
List00 
<00 
Contrato00 
>00 !
GetContratosByPeriodo00 3
(003 4
Periodo004 ;
periodo00< C
)00C D
{11 	
gestorAccesoDatos22 
.22 
AbrirConexion22 +
(22+ ,
)22, -
;22- .
List33 
<33 
Contrato33 
>33 
	contratos33 $
=33% &
contratoDAO33' 2
.332 3!
GetContratosByPeriodo333 H
(33H I
periodo33I P
)33P Q
;33Q R
gestorAccesoDatos44 
.44 
CerrarConexion44 ,
(44, -
)44- .
;44. /
return55 
	contratos55 
;55 
}66 	
public77 
bool77 
registerPago77  
(77  !
Pago77! %
pago77& *
)77* +
{88 	
gestorAccesoDatos99 
.99 
AbrirConexion99 +
(99+ ,
)99, -
;99- .
bool:: 
	registrar:: 
=:: 
pagoDAO:: $
.::$ %
registerPago::% 1
(::1 2
pago::2 6
)::6 7
;::7 8
gestorAccesoDatos;; 
.;; 
CerrarConexion;; ,
(;;, -
);;- .
;;;. /
return<< 
	registrar<< 
;<< 
}== 	
public>> 
List>> 
<>> 
Pago>> 
>>> 
GetPagpsByPeriodo>> +
(>>+ ,
Periodo>>, 3
periodo>>4 ;
)>>; <
{?? 	
gestorAccesoDatos@@ 
.@@ 
AbrirConexion@@ +
(@@+ ,
)@@, -
;@@- .
ListAA 
<AA 
PagoAA 
>AA 
pagosAA 
=AA 
pagoDAOAA &
.AA& '
GetPagosByPeriodoAA' 8
(AA8 9
periodoAA9 @
)AA@ A
;AAA B
gestorAccesoDatosBB 
.BB 
CerrarConexionBB ,
(BB, -
)BB- .
;BB. /
returnCC 
pagosCC 
;CC 
}DD 	
publicEE 
ContratoEE 
GetContratoEE #
(EE# $
intEE$ '
idEE( *
)EE* +
{FF 	
gestorAccesoDatosGG 
.GG 
AbrirConexionGG +
(GG+ ,
)GG, -
;GG- .
ContratoHH 
contratoHH 
=HH 
contratoDAOHH  +
.HH+ ,
GetContratoHH, 7
(HH7 8
idHH8 :
)HH: ;
;HH; <
gestorAccesoDatosII 
.II 
CerrarConexionII ,
(II, -
)II- .
;II. /
returnJJ 
contratoJJ 
;JJ 
}KK 	
publicLL 
EmpleadoLL 
BuscarEmpleadoLL &
(LL& '
intLL' *
idLL+ -
)LL- .
{MM 	
gestorAccesoDatosNN 
.NN 
AbrirConexionNN +
(NN+ ,
)NN, -
;NN- .
EmpleadoOO 
empleadoOO 
=OO 
empleadoDAOOO  +
.OO+ ,
BuscarEmpleadoOO, :
(OO: ;
idOO; =
)OO= >
;OO> ?
gestorAccesoDatosPP 
.PP 
CerrarConexionPP ,
(PP, -
)PP- .
;PP. /
returnQQ 
empleadoQQ 
;QQ 
}RR 	
publicSS &
ConceptoIngresoDeDescuentoSS )$
GetCIDByContrato_PeriodoSS* B
(SSB C
intSSC F

idContratoSSG Q
,SSQ R
intSSS V
	idPeriodoSSW `
)SS` a
{TT 	
gestorAccesoDatosUU 
.UU 
AbrirConexionUU +
(UU+ ,
)UU, -
;UU- .&
ConceptoIngresoDeDescuentoVV &
cidVV' *
=VV+ ,
contratoDAOVV- 8
.VV8 9$
GetCIDByContrato_PeriodoVV9 Q
(VVQ R

idContratoVVR \
,VV\ ]
	idPeriodoVV^ g
)VVg h
;VVh i
gestorAccesoDatosWW 
.WW 
CerrarConexionWW ,
(WW, -
)WW- .
;WW. /
returnXX 
cidXX 
;XX 
}YY 	
}ZZ 
}[[ 