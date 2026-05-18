# C# OOP Intro

Modul 3 of Emne 3 at Get Academy — introduction to object-oriented programming. Classes, objects, properties, constructors, methods, and lists of objects.

Single console project with a menu — each oppgave is its own entry class. Run the app, pick a number, see the exercise output.

Each oppgave lives in its own numbered folder; all classes share the flat `CsharpOopIntro` namespace.

## Oppgaver

| # | Entry class | Curriculum (NO) | What |
|---|---|---|---|
| 1 | `StudentAdministration` | Studentadministrasjon | Student, Subject and Grade classes; lists of subjects and grades per student; average grade and total credits. |
| 2 | `OrganTransplant` | Organtransplantasjon | Patient, Donor and Kidney objects; pre-tested compatibility (`IsHealthy` + `IsCompatibleWith`). Scenario: Bernt receives a kidney from his cousin Kåre. |
| 3 | `FriendFace` | Sosiale medier | Profile class with friend list and personal info; `AddFriend` / `RemoveFriend` on `Profile` references. Logged-in user navigates a master list of 5 users via a console submenu. |
| 4 | `Bossfight` | Bossfight | GameCharacter with Health, Strength, Stamina; Fight and Recharge loop. *(not yet implemented)* |

## Run

```powershell
dotnet run
```
