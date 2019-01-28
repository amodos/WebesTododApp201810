# WebesTododApp201810
A Netacademia Webes TodoApp Tanfolyama

## A tanfolyam célja:
```  
                                             
                                             +--------------------------------+
                                             |                                |
                                             |       Desktop számítógép       |
+--------------------+                       |    +------------------------+  |
|                    |                       |    | Alkalmazás             |  |
|                    |                       |    |                        |  |
|    Felhasználó     |                       |    +------------------------+  |
|                    |                       |                                |
|                    |                       |                                |
|                    |                       |                                |
+--------------------+                       |                                |
                                             +--------------------------------+
            Hagyományos Desktop/Mobil alkamazásfejlesztés
```
```
                                                                                +-------------------------------------+
                                                                                |                                     |
                                 +--------------------------------+ Hálózati    |   Szerver számítógép                |
                                 |        Desktop számítógép      | Kapcsolat   |                                     |
+--------------------+           |           Mobil eszköz         |             |   +--------------------------+      |
|                    |           |    +------------------------+  +-----------> |   |                          |      |
|                    |           |    |        Alkalmazás      |  |             |   |Szerver alkalmazás        |      |
|    Felhasználó     |           |    |        (Böngésző)      |  |             |   |(Web szerveren futó app)  |      |
|                    |           |    +------------------------+  | <-----------+   |                          |      |
|                    |           |                                |             |   +--------------------------+      |
|                    |           |                                |      ^      |                                     |
+--------------------+           |                                |      |      |                                     |
                                 |                                |      |      |                                     |
                                 +---------------+----------------+      |      |                 ^                   |
                                                 ^                       |      |                 |                   |
                                                 |                       |      |                 |                   |
                                                 |                       |      |                 |                   |
                                                 |                       |      |                 |                   |
                                                 |                       |      +-------------------------------------+
                                                 |                       |                        |
                                                 |                       |                        |
                                                 |                       |                        |
                                                 +                       +                        |
                                               HTML                    HTTP                       +
                                                                                                 MVC
                                                       Webes Alkalmazásfejlesztés
```
## Az első webes alkalmazásunk létre hozása
Mivel a környezet és a fejlesztési munkafolyamat az ilyen típusú fejlesztéseknél összetett, így nem kézzel hozuk létre, hanem templétel

az ASP.NET MVC Webalkalmazás (Framwork)


### Saját html oldal létrehozása és kiszolgálása
Ha létrehozunk egy html álományt az alalmazás könyvtárában, azt alapértelmezésben az ASP.NET alkalmazás szolgáltatja.


Ez a  kérés ( a böngészőből)
```
GET http://localhost:56433/SajatHtmlOldal.html

```


Ez ugyanúgy működik , ha file-t nyitjuk meg a böngészőből.

### HTTP: Ha az állomány nem  afile rendszerben van hanem egy másik szerveren van

A HTTP feladata: Kérések meg fogalmazását és a válaszok formátumát írja le ha a hálózaton keresztül szeretnénk lekérdezni.

A HTTP kérés négy részből áll:
- kérés (cím+metódus)
- tartalom
- fejlécek
- végálapot

Ebből minket az első körben az első kettő érdekel.

Metódus: pl: GET, POST, PUT, DELET, stb...
Részletek a [wikipédián](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol)

fontos még, hogy a HTTP protokol álapotot nem kezel, így a kérések egymástól teljesen fügetlenek.

### MVC: Dinamikus weblapokból készített webalkalmazás
Ha nem statikus lapok egymásutánját szeretnénk megjelenitenni, hanem 
- egy jól kinéző formátumot meghatározni az összes oldalra
- saját adatokat mentenni a webolda megfelelő helyére
- az alkalmazás interakcijóját megswzervezni

Az egy szép feladat, erre szolgál az ASP.NET MVC

### Konkrét feladat TODO alkalmazás

Bevásárlólista készítése


Megjelenitésnél
- a megjekenitésnél kezeljük a weboldaltól
- a weboldal legyen szép

### MVC alkalmazás főbb részei

- MVC:Model-View- Controller
	-Controller
		A kérést fogadó objektum, az őfelelősége a kérésre a választ létrehozni, vagy delegálni, ésa  válasz visszajutatása a kérőhöz

Kérdés hogy jut el a kérdés a controlerhez Válasz a kérés cím alapján

Ennek a feldolgozása a **Routing** (útválasztás) feladata. A címben a  "/" az elválasztást jelentő jel, vagyis, ennek mentén lehet szétszedni a teljes címet.

Az ASP.NET MVC konvenció szerint,
	-az első része ennek címnek a **controllert**(a példában :Home)
	-a másidik része pedig azt az **Action**, ami kiszolgálja a kérést. Action: fügvény

Ennek a segítcségével az egyes kéréseket fügvényekbe tudjuk szervezni, és a fügvényeket pedig vezérlő egységekbe

Fontos, a címeket a többi része, ami az első kettő egycséget (Controller/Action) követi,a kérést paramétererit fogja tartalmazni valamilyen formában

### Conroller

-Általában az alkalmazás Controllers mappájába teszük, az átekintehtőség milyat.
-Leszármaztatjuk  aController osztályból (kötelező) (System. Web.MVC Controller ez a webalkalmazához, a weblapok generálását felelős
-Az osztály neve mindig ugy végződik hogy Controller, de a routingban ezt nem használjuk csak a Controller előtti részét.

Az ASP.NET MVC keretredszer rendkívül erősen épít a név konvencióra: egy-egy elem neve meghatározó szerepet tölt be az alkalmazás működésében

Két fontos routing szabály van 
- ha az Action nincs megadva akkor az **Index**.
- ha a Controller nincs megadava akkor  a **Home**

#### A nézet (View)
Név konvenció alapján

-MVC:Mode-View-Controller
	-View
	Olyen nyers HTML álomány, ami képes értelmes HTML szöveget előállítani. 
	Saját szabályali vannak( Razor nyelv),ami egy- egy válasz esetén lefut, és generálja a végleges HTML-t


Általában
A Controllerhez tartozó nézetek a webalkalmazásunk \Views mappályában vannak, 


Például: a home controller nézetei a Views\Home mappában vannak
és: az egyes nézet álományok neve azonos a Controller Action nevével, amihez tartoznak

Megjedzés : azt a konvekciót megtörhetjük, ki is jelölhetünk egy Action-höz egy meghatározott View-t

A nézet képes definiálni az adatmodell típusát,amin dolgozik

-MVC:Mode-View-Controller
	-Model
	Az adatokat tartalmazó objektum ami, a Controller és a View Között az adatokat szállítja

## Az alkamazásból CRUD alkalmazás készítése a Todo elemekre
CRUD: **C**reate, **R**ead, **U**pdate, **D**elete kifejezések röviditése 

Egy rövide képernyő skicc, specifikációhoz:
```
+----------------------------------------+
|                                        |
|    +-------------------------------+   |
|    |elem 1       módosítás Törlés  |   |
|    +-------------------------------+   |
|    |elem 2       Módosítás Törlés  |   |
|    +-------------------------------+   |
|    |elem 3       Módosítás Törlés  | <----------------------------------+
|    +-------------------------------+   |                                |
|    |                               |   |                                +Műveletek kezdeményezéssére
|    +-------------------------------+   |                                 szolgáló elemek, amivel a
|    |                               |   |                                 felhasználó kezdeményezni
|    +-------------------------------+   |                                 tudja az adott műveleteket
|    |                               |   |                                 (link, gomb, stb...)
|    +-------------------------------+   |                                +
|    |                               |   |                                |
|    +-------------------------------+   |                                |
|                                        |                                |
|                                        |                                |
|                                        |                                |
|                                        |                                |
|                                        |                                |
|                                        |                                |
|                                        |                                |
|  +----------------+  +--------------+  |                                |
|  | beviteli mező  |  | rögzités     | <---------------------------------+
|  +----------------+  +--------------+  |
+----------------------------------------+

```

A controller átekintő nézette az Index, innen is kaptam a nevét. Vagyis a mi kezdeti átekintő nézetünk, az Index actonre kel kerüljön innen következik hogy átnevezük a mostanit	

### Feladatok
- indexre beviteli mező felvittele és programozása ( majd elötte)
 - [x] beviteli oldal léátrehozása
		Ahhoz, hogy adatokat küldjünk a böngészőből a szerver felé, kell
		- Kell egy űrlap `<from></from>`
		- Kell egy `<input />` aminek van neve (`<input name="valami megbevezés"/>`)
		- kell egy gomb ( `<input type="submit" />` vagy `<button></button>`)
		Ha ez mind megvan, akkor a böngésző a beviteli mező tartamát beteszi a hívás paraméterei közé.
 - [x] beviteli oldal elérhetővé tétele az indexen oldalon (link formájában: Todo/Create)
		linkek setén használható a ralatív cím fogalma : /Todo/Create
		vagy használhatjuk a beépített megoldást: ActionLink
 - [x] Teszt adatok , amik kérések között is megmaradnak
 - [x] Adatbevitel programozása POST segítségével 
		Post esetén az adatok Form paraméterként érkeznek:

		Amit a Model Binder segítségévelugyanúgy ugyan úgy fügvény paraméterként tudunk kezelni
 


 - [] indexre a beviteli mező tétele és a bevitel programozása