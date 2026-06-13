# Alisher.StringExtensions

Matnlar (string) bilan ishlashni osonlashtiruvchi extension metodlar to‘plami.

## O‘rnatish

```bash
dotnet add package Alisher.StringExtensions

using Alisher.StringExtensions;

string text = "salom dunyo";

// Misollar
Console.WriteLine(text.ToTitleCase());        // "Salom Dunyo"
Console.WriteLine(text.IsEmail());            // false
Console.WriteLine("   test   ".TrimAndLower()); 
Console.WriteLine(text.RemoveDiacritics());

Hozirgi metodlar

ToTitleCase()
IsEmail()
va boshqalar…
