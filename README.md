# CashierConsole 

This program simulates a cashier that dispenses money. It accepts an input from a user, calculates the change, and then outputs it.

## Prerequisites
.NET Framework 4.7 or later

## Usage
Open the command line (e.g. "cmd" on Windows or "Terminal" on macOS).
Navigate to the folder that contains the program.
Build the program with the command dotnet build.
Run the program with the command dotnet run.
Enter the amount to be withdrawn when prompted.
The program outputs the change if it can be calculated successfully.

## Functionality
The program consists of three methods:

EingabeBetrag(): This method prompts the user to enter the amount to be withdrawn and then returns it as an integer.
BerechneRueckgeld(int eingegeben, int[] noten): This method calculates the change to be dispensed, divided into the various banknotes defined in the noten array. It returns an array of integers containing the number of banknotes to be used for each denomination. If no change can be calculated, the method returns null.
AusgabeRueckgeld(int[] noten, int[] anzahlNoten): This method outputs the calculated change, defined in the noten array, together with the number of banknotes to be used for each denomination.
The main program (Main()) calls these methods in the correct order and outputs error messages if something goes wrong.

## Limitations
The program currently only accepts positive integers as input.
The program cannot calculate change that is less than 5 euros. In this case, it outputs an error message and terminates.
The program cannot calculate change that cannot be divided into the available banknotes. In this case, it outputs an error message and terminates.



# CashierConsole (Deutsch)
Dieses Programm simuliert eine Kasse, die Geld ausbezahlt. Es akzeptiert eine Eingabe von einem Benutzer, berechnet das Rückgeld und gibt es dann aus.

## Voraussetzungen
.NET Framework 4.7 oder höher

## Verwendung
Öffnen Sie die Befehlszeile (z. B. "cmd" unter Windows oder "Terminal" unter macOS).
Navigieren Sie zum Ordner, der das Programm enthält.
Kompilieren Sie das Programm mit dem Befehl dotnet build.
Führen Sie das Programm mit dem Befehl dotnet run aus.
Geben Sie den abzuhebenden Betrag ein, wenn Sie dazu aufgefordert werden.
Das Programm gibt das Rückgeld aus, wenn es erfolgreich berechnet werden kann.

## Funktionsweise
Das Programm besteht aus drei Methoden:

EingabeBetrag(): Diese Methode fordert den Benutzer auf, den abzuhebenden Betrag einzugeben, und gibt ihn dann als Ganzzahl zurück.
BerechneRueckgeld(int eingegeben, int[] noten): Diese Methode berechnet das Rückgeld, das auf die verschiedenen Banknoten aufgeteilt wird, die im noten-Array definiert sind. Es gibt ein Array von Ganzzahlen zurück, das die Anzahl der Banknoten enthält, die für jede Stückelung verwendet werden sollen. Wenn kein Rückgeld berechnet werden kann, gibt die Methode null zurück.
AusgabeRueckgeld(int[] noten, int[] anzahlNoten): Diese Methode gibt das berechnete Rückgeld aus, das im noten-Array definiert ist, zusammen mit der Anzahl der Banknoten, die für jede Stückelung verwendet werden.
Das Hauptprogramm (Main()) ruft diese Methoden in der richtigen Reihenfolge auf und gibt Fehlermeldungen aus, wenn etwas schief geht.

## Einschränkungen
Das Programm akzeptiert derzeit nur positive Ganzzahlen als Eingabe.
Das Programm kann kein Rückgeld berechnen, das kleiner als 5 Euro ist. In diesem Fall gibt es eine Fehlermeldung aus und das Programm beendet sich.
Das Programm kann kein Rückgeld berechnen, das nicht auf die verfügbaren Banknoten aufgeteilt werden kann. In diesem Fall gibt es eine Fehlermeldung aus und das Programm beendet sich.