# Lern-Bericht

Kamil 

## Einleitung

Im LA1100 haben wir ein number guessing game programmiert.

## Was habe ich gelernt?


Ich habe gelernt, wie man die Konsolenausgabe farbig machen kann
## Beschreibung



Mit dem Befehl `Console.ForegroundColor = ConsoleColor.Red` kann man die Konsolenausgabe (Font) rot machen.
Mit dem Befehl `Console.BackgroundColor = ConsoleColor.Grey`kann man den Hintergrund in einer anderen Farbe haben,
Leider sieht Background nicht so schön aus wie bei Foreground. Die beiden Befehlen werden so lange ausgeführt, bis es zu einer anderen Farbe gewechselt wird,
damit meine ich, wenn man am Anfang den Befehl schreibt, dass die Farbe Rot sein sollte, dann werden alle Console.WriteLine's rot ausgegeben bis es wieder gewechselt wird


![Bild](https://i.imgur.com/bumtbER.png)


```
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            // here you can change the background of the output font !Important: It only changes the font background, not the whole console bckground
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // here you can change the font color of the console output
            Console.WriteLine("Hello World!");
        }
    }
}

```

## Verifikation

In dem Text habe ich beschrieben, wie man die Befehle benutzt und auf was man noch aufpassen sollte

Auf das Bild sieht man die Konsolenausgabe von dem Code sehen

Der Code Snippet zeigt wie man die Funktion im einen Programm anwendet

# Reflexion zum Arbeitsprozess


Ich war motiviert, da ich mehrmals von zu Hause arbeiten könnte und ausschlafen könnte

Ich habe die Motivation schnell verloren, wenn ich nicht gewusst habe, wie ich weitermachen soll oder wenn ich keine Antwort im Internet finden könnte

**VBV**: 
Plan genau verfolgen und wenn etwas nicht klappt weiter machen 
