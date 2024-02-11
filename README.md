#Dokumentacja Projektu

Dane techniczne:
.NET Core 6.0
Użyte pakiety:
Microsoft.AspNetCore.Identity.EntityFramework
Microsoft.AspNetCore.Identity.UI
Microsoft.AspNetCore.Mvc.DataAnnotations
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Tools
Microsoft.VisualStudio.Web.CodeGeneration.Design

Przegląd
Aplikacja służy do zarządzania pracownikami i pracodawcami. Umożliwia ona tworzenie, przeglądanie, edytowanie i usuwanie danych pracowników oraz pracodawców.

W razie chęci testów wszystkich możliwych funkcjonalności proszę użyć konta:
admin@wsei.edu.pl
P@ssword1

Architektura
Projekt oparty jest na ASP.NET Core z użyciem wzorca MVC (Model-View-Controller) oraz widoków Razor.

Utrwalanie Danych
Wykorzystanie Entity Framework Core.
Baza danych: SQLite.
AppDbContext służy do konfiguracji połączenia z bazą danych oraz definicji DbSet dla encji.

Encje
EmployeeEntity: reprezentuje pracowników z polami takimi jak Imię, Nazwisko, PESEL itp.
EmployerEntity: reprezentuje pracodawców.
AddressEntity: zawiera adresy pracodawców.
Relacje: Każdy pracownik (EmployeeEntity) jest przypisany do pracodawcy (EmployerEntity).

Moduł Identity
Uwierzytelnianie i autoryzacja użytkowników.
Role: Administrator i zwykły użytkownik.
Obsługa rejestracji i logowania.

Operacje CRUD
Kontrolery EmployeeController i EmployerController dla operacji CRUD.
Walidacja danych i obsługa błędów w formularzach.

Widoki i Formularze
Formularze do dodawania, edycji i usuwania pracowników i pracodawców.
Użycie Bootstrap do stylizacji formularzy.
Walidacja po stronie klienta.

Kontroler API
Wyszukiwarka pracowników na podstawie wybranej kategorii oparta o kontroler API

Podsumowanie
Aplikacja stanowi kompleksowe rozwiązanie do zarządzania pracownikami i pracodawcami, z możliwością dalszego rozwoju i implementacji nowych funkcjonalności.
