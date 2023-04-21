//deklarujemy funkcję zwracającą stringa i przyjmującą stringa jako argument
string toAsciiCaesar (string clearText)
{
   

    //zmieniamy na wielkie litery
    clearText = clearText.ToUpper();
    //literuj przez cały tekst litera po literze
    //deklarujemy string wynikowy
    string encryptedText = "";
    foreach (char c in clearText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej litery
            //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //dodajemy wartość klucza
            asciiCode += 3;
            //sprawdzamy czy nie przekroczyliśmy ostatniego znaku (z, 90)
            if (asciiCode > 90)
                //jeśli przekroczyło to cofnij o długość alfabetu
                asciiCode -= 26;
            //zmieniamy kod z powrotem na znak
            char encryptedChar = (char)asciiCode;
            //dopisujemy do szyfru
            encryptedText += encryptedChar;
        }
    }
    //zwróć zakodowany string
    return encryptedText;
}

string fromAsciiCaesar(string encryptedText)
{
    string clearText = "";
    //todo: napisz funkcję
    encryptedText = encryptedText.ToUpper();
    foreach(char c in encryptedText)
    {
        int asciiCode = (int)c;
        asciiCode -= 3;
        if (asciiCode < 65)
        {
            asciiCode += 26; 
        }
    }

    //zwróć wartość
    return clearText;
}

//zdefiniuj string do zaszyfrowania 
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma ryia";

Console.WriteLine("Zaszyfrowany Tekst: " + toAsciiCaesar(clearText));

