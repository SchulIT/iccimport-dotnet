# ICC Import (.NET Core)

[![Build Status](https://dev.azure.com/schulit/IccImport/_apis/build/status/SchulIT.iccimport-dotnet?branchName=master)](https://dev.azure.com/schulit/IccImport/_build/latest?definitionId=6&branchName=master)
[![NuGet version (SchulIT.IccImport)](https://img.shields.io/nuget/v/SchulIT.IccImport.svg?style=flat-square)](https://www.nuget.org/packages/SchulIT.IccImport/)
![GitHub](https://img.shields.io/github/license/schulit/iccimport-dotnet?style=flat-square)
![.NET Standard 2.1](https://img.shields.io/badge/.NET%20Standard-2.1-brightgreen?style=flat-square)

Diese Bibliothek stellt alle Klassen zur Verfügung, um
Daten in das [ICC](https://github.com/schulit/icc) mittels .NET Core hochzuladen.

## Installation

Die Installation erfolgt via NuGet.

## Nutzung

Alle Methoden sind asynchron und müssen daher mit einem `await` aufgerufen werden. Die Nutzung eines DI-Frameworks (bspw. Autofac) ist mittels des Interfaces `IIccImporter` möglich.

```csharp
var logger = Microsoft.Extensions.Logging.LoggerFactory.CreateLogger<IccImporter>(); // Falls man kein DI nutzt, erstellt man einen Logger
var importer = new IccImporter(logger);
importer.BaseUrl = "https://icc.example.com/";
importer.Token = "YourToken";

var absences = new List<AbsenceData>();
// Absenzen konstruieren

var response = await importer.ImportAbsencesAsync(absences);

if(response is ImportResponse) {
    var importResponse = response as ImportResponse;
    /*
     * Ausgabe über Erfolg generieren
     */
} else if(response is ErrorResponse) {
    var errorResponse = response as ErrorResponse;

    /*
     * Fehlermeldung erzeugen
     * Man hat Zugriff auf errorResponse.ResponseCode, errorResponse.ResponseBody und errorResponse.Message
     */
}

```

Weitere Methoden zum Importieren:

* `ImportAppointmentsAsync(appointments)`: Termine
* `ImportAppointmentCategoriesAsync(categories)`: Termin-Kategorien
* `ImportExamsAsync(exams)`: Klausuren
* `ImportGradesAsync(grades)`: Klassen
* `ImportGradeTeachersAsync(gradeTeachers)`: Klassenleitungen
* `ImportStudentsAsync(students)`: Schülerinnen und Schüler
* `ImportStudyGroupsAsync(studyGroups)`: Lerngruppen
* `ImportStudyGroupMembershipsAsync(memberships)`: Lerngruppenmitgliedschaften
* `ImportSubjectsAsync(subjects)`: Fächer
* `ImportSubstitutionsAsync(substitutions)`: Vertretungen
* `ImportTeachersAsync(teachers)`: Lehrkräfte
* `ImportTimetableLessonsAsync(period, lessons)`: Stundenplan-Einträge - ⚠ Hier muss stets die Periode angegeben werden, zu denen die Einträge gehören
* `ImportTimetablePeriodsAsync(periods)`: Stundenplan-Perioden
* `ImportSupervisionsAsync(period, supervisions)`: Aufsichten - ⚠ Hier muss stets die Periode angegeben werden, zu denen die Einträge gehören
* `ImportTuitionsAsync(tuitions)`: Unterrichte
* `ImportInfotextsAsync(infotexts)`: Tagestexte
* `ImportAbsencesAsync(absences)`: Absenzen
* `ImportPrivacyCategoriesAsync(categories)`: Datenschutz-Kategorien
* `ImportRoomsAsync(rooms)`: Räume

## Probleme?

Dann bitte in den [Issue schauen](https://github.com/SchulIT/iccimport-dotnet/issues), ob das Problem bereits bekannt ist. Falls nicht, kann dort ein Issue geöffnet werden. Support via E-Mail wird nicht angeboten.

## Mitmachen?

Immer gerne - einfach ein Issue öffnen oder noch besser: einen Pull Request einreichen!

## Lizenz

[MIT](LICENSE.md).