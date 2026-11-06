# Arbeidslogg – Setereservasjon: Theory og grensetilfeller

## Før koding

Min forventning og begrunnelse:

Hensikten med [Theory] er og lage en repeterbar test, og bruke den flere ganger
den første verdien kobles til int requested. Så int available. Og til slutt expected. De kjøres en test per [InlineData]
Assert kontrollerer at bool verdien fra metoden blir lik som vi forventer utifra variablene våre.

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|requested 1, available 4 |true |true | |
|requested 5, available 4 |false |false | |
|requested 4, available 4 |true |false | |

utvidelse

|requested 1, available 4 |true |pass | |
|requested 3, available 4 |true |pass | |
|requested 4, available 4 |true |failed | |
|requested 5, available 4 |false |pass | |
|requested 0, available 4 |false |pass | |
|requested -1, available 4 |false |pass | |
|requested 1, available 0 |false |pass | |

Jeg så at hvis requested var det samme som available. Ble false returnert. Det er feilen.
Jeg så i SeatPolicy.cs og metoden brukte denne: return requested > 0 && requested < available;
Her må requested være mindre enn available. Men den skal kunne være mindre eller lik.
Jeg endret til 
return requested > 0 && requested <= available;
nå passerer alle tester
## Etterpå

Hvilke filer endret jeg, og hvorfor?
SeatPolicy.cs. Jeg endret på metoden CanReserve for og få korrekt handling

Svar på refleksjonsspørsmålene:
