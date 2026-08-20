# Bibliotheksverwaltung

Eine einfache Bibliotheksverwaltung in C# mit Windows Forms.

Mit der Anwendung können Bücher erfasst, angezeigt, gesucht, entfernt und gespeichert bzw. geladen werden.

## Funktionen

- Bücher hinzufügen
- Bücher aus der Liste entfernen
- Bücher suchen
- Titel und Autor eines Buches eingeben
- Bücher in einer Liste anzeigen
- Bücher in einer JSON-Datei speichern
- Bücher aus einer JSON-Datei laden

## Aufbau des Projekts

Das Projekt ist in mehrere Bereiche aufgeteilt:

### Bibliotheksverwaltung.Core

Enthält die grundlegende Logik der Bibliotheksverwaltung.

Zum Beispiel:

- `Bibliothek.cs`
- `Buch.cs`

Die Core-Bibliothek kümmert sich um die Verwaltung der Bücher und die Speicherung bzw. das Laden der Daten.

### BibliotheksverwaltungGUI

Enthält die grafische Benutzeroberfläche der Anwendung.

Die Oberfläche wurde mit Windows Forms erstellt.

## Speicherung

Die Bücher werden als JSON-Datei gespeichert.
