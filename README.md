# Tekstistä Lukuun ja toisinpäin

## JOHDANTO
- Hyödynnä aina aiemmin oppimaasi.
- Muista: Numeromuuttuja ei voi sisältää tekstiä, pelkästään numeroita.
- Muista: Tekstimuuttujan täytyy aina olla hipsujen " " sisällä.
- Alustettu muuttuja sisältää arvon luomisestaan alkaen.
- Alustamaton muuttuja ei sisällä arvoa luontihetkellä.
- Jos konsolin syötteessä on vain lukuja ja + merkkejä, laskee konsoli automaattisesti luvut yhteen. Jos siellä on tekstiä ja + merkkejä, se tulostaa tekstin peräjälkeen. Konsoli toimii kuin laskin ja kunnioittaa aina laskujärjestystä; sulut, kerto ja jako, plus ja miinus - vasemmalta oikealle.
- Toiminto int.Parse(); muuttaa muuttujan arvon int muotoon
- Toiminto Convert.toString(); muuttaa muuttujan arvon string muotoon
## TEHTÄVÄNANTO
- Tee konsolisovellus, jossa on tekstimuuttuja teksti, joka on alustettu arvoon "1". Tee myös alustamaton int muuttuja luku sekä alustamaton tekstimuuttuja teksti2.
- Tutustu konsolitoimintoon Parse tekemällä muuttujien luomisen jälkeen muuttujan tyyppiä muuttava komento:
luku = int.Parse(teksti);
- Tee nyt kaksi konsoliin kirjoittavaa toimintoa, ensimmäiseen kirjoita syötteeksi (teksti+teksti) toiseen (luku+luku). Katso tässä välissä mitä konsoliin tulostuu. Mieti mitä tähän asti kirjoittamassasi koodissa tapahtu, kommentoi koodiin mitä tapahtuu.
- Tee seuraavaksi teksti2 muuttujan sisällöksi Convert.toString(luku); ja lisää sen jälkeen writeline toiminto tulosteella (teksti2+teksti2)
- Mitä tapahtuu? Kerro kommentissa.
- Tulosteen pitäisi näyttää tältä, jos se ei toimi tai näytä tältä mieti ensin miten korjaat sen ja kysy sitten apua jos et keksi:
  
```
11
2
11
```

> [!IMPORTANT]
> Koodin kirjoittamisen johdanto
1. Kloonaa projekti omalle koneellesi.
2. Avaa `ConsoleApp.sln`.
3. Solution-ikkunasta valitse "ConsoleApp".
4. Pääkoodi löytyy `Program.cs`-tiedostosta. Jos tarvitset, luo uudet itemit `ConsoleApp`-projektiin.
