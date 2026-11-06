# Arbeidslogg – Forsyninger: fra krav til testeksempler

## 1. Forventet og faktisk resultat

Fyll inn **Forventet** før du kjører programmet. Etter at du har kjørt alle fem tilfellene, fyller du inn **Faktisk** og om resultatene stemte.

| Inndata | Forventet | Faktisk | Stemte det? |
|---|---|---|---|
| 3 personer, 4 dager |24 |24 | ja|
| 0 personer, 4 dager |0 | 0| ja|
| 3 personer, 0 dager |0 | 0| ja|
| 1 person, 1 dag |2 | 2| ja|
| 20 personer, 30 dager |1200 |1200 | ja|

Hvordan fant du frem til de forventede resultatene?

## 2. Prøv å innføre en feil

Endre multiplikatoren fra 2 til 3, og kjør programmet på nytt.

**Hvilke tilfeller avslørte feilen?**

alle utregninger ble feil. Med 1.5 ganger mer enn forventet

**Hvilke tilfeller ga fortsatt riktig resultat?**

tilfellene hvor en eller mer av variabler var 0. Fordi 0 ganger 2 == 0 ganger 3

**Hvorfor kan nulltilfellene gi riktig resultat selv om multiplikatoren er feil?**

Fordi 0 ganger 2 == 0 ganger 3

Husk å endre multiplikatoren tilbake til 2.

## 3. Refleksjon

Hvorfor er det ikke nok at programmet skriver ut et resultat for å avgjøre om en test består?

Man burde alltid dobbeltsjekke at resultatet blir det man forventet. Slik at programmet blir riktig i henhold til ønsket oppførsel

## 4. Endringer

Hvilke filer endret du, og hvorfor?
jeg endret Program.cs for og gjøre fler utregninger samtidig
jeg endret FuelCalculator.cs for og teste ut feil i utregningsmodell.