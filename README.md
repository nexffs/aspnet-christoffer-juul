# 🏋️ CoreFitness WebApp

Detta är en ASP.NET Core MVC-webbapplikation för ett gym, där användare kan hantera sitt konto, medlemskap och bokningar.

---

## 🚀 Kom igång lokalt

Följ stegen nedan för att köra projektet på din egen dator.

---

## 📦 Krav

Se till att du har följande installerat:

* .NET SDK (rekommenderat: .NET 8 eller enligt projektets version)
* Visual Studio / Visual Studio Code
* SQL Server (LocalDB eller full version)

---

## 🔧 Installation

### 1. Klona projektet

```bash
git clone https://github.com/<your-repo>/corefitness-webapp.git
cd corefitness-webapp
```

---

### 2. Ställ in databasen

1. Öppna `appsettings.json`
2. Uppdatera din connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CoreFitnessDb;Trusted_Connection=True;"
}
```

---

### 3. Kör migrations

Om projektet använder Entity Framework:

```bash
dotnet ef database update
```

---

### 4. Starta projektet

```bash
dotnet run
```

eller via Visual Studio:

* Klicka på **Start (F5)**

---

## 🌐 Öppna i webbläsaren

När projektet startar visas en URL, t.ex:

```
https://localhost:5001
```

Öppna den i din webbläsare.

---

## 👤 Funktioner

* Hantera användarkonto (About Me)
* Ladda upp profilbild
* Visa medlemskap
* Visa bokningar
* Logga ut / ta bort konto

---

## 📁 Projektstruktur (översikt)

```
/Controllers
/Views
/Models
/Services
/wwwroot (CSS, bilder, JS)
/Areas/Account
```

---

## 🎨 Styling

* CSS är uppdelad per sida/sektion
* Font Awesome används för ikoner
* Design baserad på Figma

---

## ⚠️ Vanliga problem

### 🔹 Bilder laddas inte

Kontrollera att:

```
wwwroot/images/
```

innehåller rätt filer.

---

### 🔹 Databasfel

* Kör `dotnet ef database update`
* Kontrollera connection string

---

### 🔹 CSS laddas inte

* Kontrollera att `wwwroot` används korrekt
* Hard refresh i browser (`Ctrl + F5`)

---

## 🛠️ Utveckling

För att fortsätta utveckla:

```bash
dotnet watch run
```

Detta uppdaterar sidan automatiskt vid ändringar.

---

## 📄 Licens

Detta projekt är endast för utbildningssyfte.

---

## ✨ Författare

Utvecklad av: *Christoffer Juul*

---
