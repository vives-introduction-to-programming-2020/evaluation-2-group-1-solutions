# Find the Key

`KeyValueParser` is een class die toelaat om een key-value string te parsen die voldoet aan het formaat: `key: value`. Key is hierbij een soort van label dat je geeft aan de waarde (value). De key-value wordt dan als `string` voorgesteld.

Bv.:

* `message: Hello World`, hierbij is `message` de key en `Hello World` de value.
* `email: nico.dewitte@vives.be`, waarbij de key `email` is en de value `nico.dewitte@vives.be`.

Jouw taak (zie `View => Task List` in Visual Studio) bestaat uit het implementeren van de twee methodes `IsValid()` en `GetValue`:

* De `IsValid()` methode zou enkel `true` mogen returnen als de key-value string een geldig formaat heeft (niet leeg is en een dubbel punt (colon) heeft)
* De `GetValue()` methode dient de `text` string te parsen en de `value` er uit te halen. Indien de text niet geldig is, dien je een lege string te returnen.

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Welcome to Find the Key

Value of keyValue "name: Nico De Witte" => "Nico De Witte"
Value of invalid "This is not a valid string" => ""
Value of empty "" => ""
Value of another "msg: Hello World" => "Hello World"
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
