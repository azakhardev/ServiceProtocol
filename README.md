# Servisní protokol – školní předmaturitní projekt
## Popis projektu
Tento program slouží k tvorbě servisního protokolu (revizní zprávy). Uživatel může zadat základní informace o zákazníkovi, zařízení a výsledcích měření. Program následně umožňuje náhled, export i uložení protokolu.
Speciální metodou je Vyhovuje(), která vyhodnocuje, zda zařízení splňuje požadavky pro další provoz. Zařízení je vyhovující pouze tehdy, pokud jsou všechna měření označena jako vyhovující.

## Funkcionalita
- **Tiskový náhled**
  - Protokol se zobrazí v samostatném okně.
  - Náhled je vykreslen pomocí GDI+.
  - Obsah se přizpůsobuje velikosti okna a zůstává viditelný i po překrytí jiným oknem.
- **Editace položek**
  - Uživatel může zadávat a upravovat všechny údaje protokolu.
  - Probíhá validace jednotlivých polí i celého formuláře.
- **Validace vstupů**
  - Všechna pole jsou povinná.
  - PSČ musí být ve formátu 130 00.
  - IČ musí obsahovat přesně 6 číslic.
  - Naměřená hodnota musí být celé nebo desetinné číslo.
- ~~Export protokolu do HTML~~
  - ~~Protokol lze exportovat do HTML souboru.~~
  - ~~Exportovaný HTML kód je validní a obsahuje CSS pro formátování.~~
  - ~~Před exportem si uživatel zvolí cestu a název souboru.~~
- Uložení a načtení protokolu
  - Protokol je možné uložit do souboru a později znovu načíst.
  - Podporovány jsou formáty XML, textový soubor nebo binární serializace.
 
## Použité technologie
- C# / .NET
- Windows Forms
- GDI+ (vykreslování náhledu)
- ~~Serializace (XML / binární)~~
