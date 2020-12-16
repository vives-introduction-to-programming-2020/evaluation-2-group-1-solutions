# Title Builder

`ConsoleHelper` is een class die toelaat om strings te builden voor console applicaties. Zo kan het een mooie title block genereren die je dan via de console aan de gebruiker kan tonen.

Bv:

```text
##########################
# My Console Application #
# ---------------------- #
##########################
```

Hierbij is de titel `My Console Application` en wordt het kader er rond gegenereerd.

Jouw taak (zie `View => Task List` in Visual Studio) bestaat er nu uit om deze methode `GenerateTitle()` te implementeren. Een paar specificaties waaraan de methode moet voldoen zijn:

* Dient de resulteren string te returnen (dus geen `Console.WriteLine` in de methode)
* Maak een kader van hashtag `#` symbolen.
* Onder de titel moet er een lijn komen van dashes `-`.
* Links en rechts van de titel dienen spaties te staan.
* De breedte van het kader is afhankelijk van de lengte van de titel.

Indien gewenst mag je gerust private methodes in de class bijmaken.

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Welcome to Title Builder

#########################################
# Hello and Welcome to the second grade #
# ------------------------------------- #
#########################################
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
