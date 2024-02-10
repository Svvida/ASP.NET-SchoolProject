# ASP.NET_School
Dokumentacja Aplikacji

Funkcje Aplikacji
Utrwalanie Danych w Bazie
Baza Danych: SQLite / MS SQL
Moduł: Entity Framework
Inicjacja Danych: Aplikacja inicjuje bazę danych przykładowymi danymi pracowników (EmployeeEntity), pracodawców (EmployerEntity) oraz adresów (AddressEntity).

Związki w Bazie Danych
Związek Pracodawca-Adres: Każdy pracodawca (EmployerEntity) jest powiązany z jednym adresem (AddressEntity).
Związek Pracownik-Pracodawca: Każdy pracownik (EmployeeEntity) jest powiązany z jednym pracodawcą (EmployerEntity).

Serwis CRUD
Funkcje: Create, Read, Update, Delete
Zastosowanie: Funkcje CRUD dostępne są dla encji Pracownik, Pracodawca, Adres.
Obsługa: Zarządzanie danymi jest możliwe poprzez interfejs API.

Moduł Identity
Role: Administrator, Zwykły Użytkownik
Funkcje: Logowanie, zarządzanie rolami użytkowników.
Zastosowanie: Ograniczenie dostępu do wybranych funkcji aplikacji w zależności od roli użytkownika.

Interfejs Użytkownika
Formularze CRUD: Formularze do tworzenia, odczytu, aktualizacji i usuwania danych.

Widoki: Listy obiektów (Pracowników, Pracodawców, Adresów) z możliwością zarządzania przez administratora.


Wyszukiwanie: Możliwość wyszukiwania danych pracowników w bazie przy użyciu wyszuki opartej na WebAPI.
