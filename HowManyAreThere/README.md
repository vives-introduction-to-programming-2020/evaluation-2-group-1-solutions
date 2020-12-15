# How Many Are There

`ArrayHelper` is een kleine class die toelaat om een paar basis zoekfunctionaliteiten uit te voeren op een array van integers.

Zo laat de class toe om het kleine getal te zoeken in een array aan de hand van de methode `Minimum()`. Eveneens kan je bijvoorbeeld tellen hoe dikwijls een getal in een array voorkomt aan de hand van de methode `Count()`.

Beide methodes zijn echter nog niet geïmplementeerd. Dat is namelijk jouw taak (zie `View => Task List` in Visual Studio):

* Implementeer de methode `Count()` zodat deze in de array van getallen, `numbers`, op zoek gaat naar het aantal keer dat `value` voorkomt en return het resultaat van de methode. Zorg er wel voor dat de methode eveneens werkt met een array die geen elementen bevat en dan `0` teruggeeft.
* Implementeer de methode `Minimum()` zodat deze in de array van getallen, `numbers`, op zoek gaat naar het kleinste getal (negatieve getallen kunnen ook voorkomen). Geef het kleinste getal terug (de waarde zelf - niet de index ervan). Indien de array geen elementen bevat dien je `0` terug te geven.

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Smallest number in values: -3
Smallest number in empty: 0
Counting 22 in values: 2
Counting 22 in empty: 0
Counting -606 in values: 0
Counting -606 in empty: 0
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
