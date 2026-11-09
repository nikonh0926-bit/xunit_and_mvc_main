# Arbeidslogg – Lastestabel: LIFO og forventede unntak

## Før koding

Min forventning og begrunnelse:

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|første Pop_EmptyStack_ThrowsInvalidOperationException | failed |failed | metoden Pop() i CargoStack returnerer aldri avtalt exception|
|andre Pop_EmptyStack_ThrowsInvalidOperationException |pass |pass |Metoden Pop() må returnere forventet exception |
|Test_Stack |pass |pass | |
| Test_StackInt|pass |pass |CargoStack er bygget med generics. Så den kan bruke flere forskjellige datatyper eller klasser |
|Test_ReuseStack |pass |pass |CargoStack eksisterer selv om den er tom |




## Etterpå

Hvilke filer endret jeg, og hvorfor?
Jeg endret på CargoStack.cs for at Pop() skulle sende riktig exception

Jeg endret på ExerciseTests.cs. Jeg la til flere tester og sjekket at de passerte med forventet funksjon

Svar på refleksjonsspørsmålene:

Hvorfor ville det vært feil å endre testen slik at den forventer det utilsiktede unntaket?

Fordi metoden Pop() hadde ikke forventet funksjon. Hvis vi endrer testen for og passe til metoden vil den ikke fungere som forventet og kan gi feil senere i utviklingsfasen

Hvorfor bruker vi Assert.Throws i stedet for Assert.Equal når vi tester et forventet unntak?

Fordi vi forventer at metoden Sender en exception tilbake Da er det best og teste den spesifikke funksjonen til metoden.

Hva viser testene med CargoStack<string> og CargoStack<int> om generiske klasser?

At CargoStack fungerer for flere datatyper. Vi kan til og med bruke egne klasser, med flere felt for og få enda bedre fleksibilitet
