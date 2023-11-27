# StackPanel Demo


# WPF Layout-Demonstration

## Inhaltsverzeichnis
- [StackPanel Demo](#stackpanel-demo)
- [WPF Layout-Demonstration](#wpf-layout-demonstration)
  - [Inhaltsverzeichnis](#inhaltsverzeichnis)
  - [Einf�hrung](#einfhrung)
  - [Beispiel mit StackPanel (Aimo)](#beispiel-mit-stackpanel-aimo)
    - [XAML-Code](#xaml-code)
  - [Beispiel ohne StackPanel (Ilia)](#beispiel-ohne-stackpanel-ilia)
    - [XAML-Code](#xaml-code-1)
  - [Horizontales StackPanel (David)](#horizontales-stackpanel-david)
    - [XAML-Code](#xaml-code-2)
  - [Grid mit eingebettetem StackPanel (Arda)](#grid-mit-eingebettetem-stackpanel-arda)
    - [XAML-Code](#xaml-code-3)
  - [Schlussfolgerung](#schlussfolgerung)

## Einf�hrung
In dieser Pr�sentation werden verschiedene WPF-Layouts vorgestellt, die zeigen, wie man mit `StackPanel` und `Grid` in WPF-Anwendungen umgeht.

## Beispiel mit StackPanel (Aimo)
Ein `StackPanel` ist ein vielseitiges Layout-Panel, das seine Kinderelemente in einer einzigen Linie entweder vertikal oder horizontal anordnet.

### XAML-Code
```xml
<StackPanel>
    <Button Content="Button 1"/>
    <Button Content="Button 2"/>
    <Button Content="Button 3"/>
</StackPanel>
```

## Beispiel ohne StackPanel (Ilia)
Hier sehen wir, wie mehr Aufwand n�tig ist, um ein �hnliches Layout ohne `StackPanel`, stattdessen mit einem `Grid`, zu erreichen.

### XAML-Code
```xml
<Grid>
    <!-- Definition von Zeilen und Spalten -->
    <!-- Elemente mit expliziten Zeilen-/Spaltenangaben -->
</Grid>
```

## Horizontales StackPanel (David)
Ein `StackPanel` kann auch horizontal orientiert werden, um Elemente nebeneinander anzuordnen.

### XAML-Code
```xml
<StackPanel Orientation="Horizontal">
    <!-- Horizontale Elemente hier -->
</StackPanel>
```

## Grid mit eingebettetem StackPanel (Arda)
Ein `StackPanel` kann innerhalb eines `Grid` eingebettet werden, um die Vorteile beider Layouts zu kombinieren.

### XAML-Code
```xml
<Grid>
    <StackPanel Grid.Column="0">
        <!-- StackPanel-Inhalte hier -->
    </StackPanel>
    <!-- Weitere Grid-Inhalte -->
</Grid>
```

## Schlussfolgerung
Jedes dieser Layouts bietet verschiedene Vorteile f�r die Entwicklung von Benutzeroberfl�chen in WPF-Anwendungen. Die Wahl des richtigen Layouts h�ngt von den spezifischen Anforderungen der Anwendung ab.