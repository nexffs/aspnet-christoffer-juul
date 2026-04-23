# CoreFitness WebApp

Detta är en ASP.NET Core-webbapplikation för ett gym, utvecklad i **.NET 10** och strukturerad enligt principerna för **Clean Architecture**. Användare kan hantera sitt konto, medlemskap och bokningar.

---

## Struktur

Lösningen är uppdelad i fyra huvudsakliga projekt:

* **Presentation.WebApp**: Webbgränssnittet som hanterar routing, ASP.NET Core MVC / Razor Pages och cookie-baserad autentisering.
* **Application**: Applikationsspecifik affärslogik, gränssnitt (interfaces) och DTOs (Data Transfer Objects).
* **Domain**: Kärnan i projektet med domänentiteter.
* **Infrastructure**: Hanterar dataåtkomst via Entity Framework Core och initiering av databas.

---

## Kom igång lokalt

Följ stegen nedan för att köra projektet på din egen dator.

---

## Krav

Se till att du har följande installerat:

* [.NET 10 SDK](https://dotnet.microsoft.com/download)
* Visual Studio 2026 (eller liknande kompatibel editor)
* SQL Server (LocalDB eller full version)

---

## Installation

### 1. Klona projektet

```bash
git clone https://github.com/din-repo/corefitness-webapp.git
cd corefitness-webapp
```

---

### 2. Ställ in databasen

1. Öppna `Presentation.WebApp/appsettings.json`
2. Kontrollera att connection string är korrekt inställd för din miljö.

---

### 3. Kör migrations

Om databasen inte initieras automatiskt via `InfrastructureInitializer`, kör följande:

```bash
dotnet ef database update --project Infrastructure --startup-project Presentation.WebApp
```

---

### 4. Starta projektet

```bash
cd Presentation.WebApp
dotnet run
```

eller via Visual Studio:

* Klicka på **Start (F5)** (Säkerställ att `Presentation.WebApp` är startprojektet).

---

## 🌐 Öppna i webbläsaren

När projektet startar visas en URL i terminalen eller i Visual Studio, t.ex:

```text
https://localhost:4443
```

Öppna den i din webbläsare.

---

## 👤 Funktioner

* Hantera användarkonto (About Me)
* Ladda upp profilbild
* Visa medlemskap
* Logga ut / ta bort konto

---
