```markdown
# Geometry Calculator App

## Opis projektu

Geometry Calculator App to aplikacja WPF (Windows Presentation Foundation), która umożliwia użytkownikowi obliczanie różnych właściwości prostokąta na podstawie wprowadzonych wartości szerokości i wysokości. Aplikacja wykorzystuje architekturę MVC (Model-View-Controller) i została napisana w języku C#.

## Funkcjonalności

### Główne funkcjonalności

1. **Obliczanie powierzchni**:
   - Aplikacja oblicza powierzchnię prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

2. **Obliczanie obwodu**:
   - Aplikacja oblicza obwód prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

3. **Obliczanie przekątnej**:
   - Aplikacja oblicza długość przekątnej prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

4. **Obliczanie sumy długości wszystkich boków**:
   - Aplikacja oblicza sumę długości wszystkich boków prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

### Interfejs użytkownika

- **TextBox** do wprowadzania szerokości (`WidthTextBox`).
- **TextBox** do wprowadzania wysokości (`HeightTextBox`).
- **Button** do wywoływania obliczeń (`Calculate`).
- **TextBlock** do wyświetlania wyników obliczeń (`ResultTextBlock`).

## Uruchomienie aplikacji

### Wymagania

- Visual Studio 2019 lub nowszy
- .NET Core 3.1 lub nowszy

### Kroki do uruchomienia

1. **Klonowanie repozytorium**:
   - Skopiuj URL repozytorium i uruchom poniższe polecenie w terminalu:
     ```bash
     git clone [URL_REPOZYTORIUM]
     ```

2. **Otwórz projekt w Visual Studio**:
   - Uruchom Visual Studio.
   - Wybierz **Open a project or solution**.
   - Znajdź i otwórz plik `.sln` z repozytorium.

3. **Zbuduj projekt**:
   - Kliknij **Build > Build Solution** (lub naciśnij `Ctrl+Shift+B`).

4. **Uruchom aplikację**:
   - Kliknij **Debug > Start Debugging** (lub naciśnij `F5`).

## Struktura projektu

- `Models`:
  - **ShapeModel.cs**: Klasa zawierająca logikę obliczeń geometrycznych.
  
- `Views`:
  - **GeometryView.xaml**: Plik XAML definiujący interfejs użytkownika.
  - **GeometryView.xaml.cs**: Kod-behind obsługujący zdarzenia w widoku.

- `ViewModels`:
  - **GeometryViewModel.cs**: Klasa ViewModel łącząca logikę z interfejsem użytkownika.

- `MainWindow.xaml`:
  - Główny plik XAML, który zawiera `GeometryView`.

## Przykładowe użycie

1. **Wprowadź wartości**:
   - Wprowadź szerokość prostokąta w polu `Width`.
   - Wprowadź wysokość prostokąta w polu `Height`.

2. **Kliknij przycisk `Calculate`**:
   - Aplikacja obliczy i wyświetli następujące właściwości prostokąta:
     - Powierzchnię (`Area`)
     - Obwód (`Perimeter`)
     - Przekątną (`Diagonal`)
     - Sumę długości wszystkich boków (`Total Edge Length`)

## Kontakt

Jeśli masz jakieś pytania lub sugestie, proszę o kontakt na adres: [Twój email lub inne informacje kontaktowe].

---

Dziękujemy za używanie Geometry Calculator App!

```
