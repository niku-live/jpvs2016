#1 diena - įžanga į programavimą per kompiuterinius žaidimus
**Colobot** (www.colobot.info) - nemokamas mokomasis kompiuterinis žaidimas, skirtas susipažinti su programavimu. Žaidime astronautas pasiunčiamas į tolimas planetas vykdyti paskirtas misijas. Veikėjas žaidime viską gali atlikti pats arba gali pasinaudoti robotais, tačiau robotams reikia rašyti kompiuterines programas. Robotas gali vieną arba daugiau programų ir jos rašomos C++ kalba. Nors viską galima atlikti pačiam, tačiau norint misijas įvykdyti greitai, tą įmanoma padaryti tik pasitelkus robotus, o tokiu būdu ir mokaisi programuoti.

##Trumpai
Pagrindinės roboto valdymo komandos (naudotos per paskaitą):
- *drop()*: robotas padeda anksčiau paimtą objektą.
- *grab()*: robotas paimta jo priekyje ant žemės padėtą objektą.
- *goto(position)*: robotas keliauja į koordinatėmis *position* nurodytą vietą.
- *radar(type)*: nustatoma artimiausio objekto, esančio *type* tipo, pozicija.

Pavyzdys, kaip rasti titanium rūdą iki jos nuvažiuoti, paimti ir parvežti į kosminį laivą:
```cpp
//randame titanium rūdą esančią ne arčiau kaip 10 m. ir netoliau kaip 100000 m.
object ore = radar(TitaniumOre, 0, 360, 10, 100000);
//nuvykstame į rūdos poziciją
goto(ore.position);
//paimame rūdą
grab();
//randame kosminį laivą
object spaceShip = radar(SpaceShip);
//grįžtame ten
goto(spaceShip.position);
//padedame rūdą
drop();
```

Pavyzdys, kaip patikrinti, ar už 10 metrų egzituoja objektas:
```cpp
object ore = radar(TitaniumOre, 0, 360, 10, 10);
if (ore != null)
{
  message("Rūda egzistuoja");
}
else
{
  message("Rūdos nerasta");
}
```

##[Pavyzdinės programos](https://github.com/niku-live/jpvs2016/tree/master/Day1/Colobot)
- [Programa 1](https://github.com/niku-live/jpvs2016/blob/master/Day1/Colobot/MoonLevel_WheeledGrabber.txt) - programa paskiria robotą išdėlioti kosminiame laive esančias atsargas apie laivą, tai supaprastina įvairių pastatų statybą.
- [Programa 2](https://github.com/niku-live/jpvs2016/blob/master/Day1/Colobot/MoonLevel_WingedGrabber.txt) - programa paskiria robotą ieškoti titanium rūdos ir ją parnešti į kosminį laivą.
- [Programa 3](https://github.com/niku-live/jpvs2016/blob/master/Day1/Colobot/RobotPositionInfo.txt) - programa, kuri ekrane pateikia esamą roboto poziciją (naudingą norint suprasti, kur kokios koordinatės)
