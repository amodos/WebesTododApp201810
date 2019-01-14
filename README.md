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

### MVC: Dinamikus weblapokból készített webalkalmazás
Ha nem statikus lapok egymásutánját szeretnénk megjelenitenni, hanem 
- egy jól

