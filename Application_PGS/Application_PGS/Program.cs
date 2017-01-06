namespace Application_PGS

{

    /// <summary>
    /// Klasa, w której znajduje się funkcja Main.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Główna pętla programu
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            int option = 1; // zmienna odpowiedzialna za odpowienie wpisywane parametry
            int poprawka = 0; // zmienna, która zostaje ustawiona na wartość jeden, gdy po raz pierwszy użytkownik wpisze wszystkie dane
            int i = 0; // zmienna warunkująca nieskończone wykonywanie pętli while


            Interface obraz = new Interface();      // inicjalizacja interface'u

            while (i == 0)
            {

                switch (option)
                {

                    case 1:     // wpisywanie imienia
                        {
                            option = obraz.Imie();
                            option = obraz.sprawdz(poprawka, option); // funkcja, warunkuje zmianę tylko jednego parametru, gdy wszystkie parametry podane zostaną po raz pierwszy
                        }
                        break;
                    case 2:     // wpisywanie nazwiska
                        {
                            option = obraz.Nazwisko();
                            option = obraz.sprawdz(poprawka, option);
                        }

                        break;

                    case 3:     // wpisywanie adresu
                        {
                            option = obraz.Adres();
                            option = obraz.sprawdz(poprawka, option);
                        }
                        break;

                    case 4:     // wpisywanie numeru telefonu
                        {
                            option = obraz.Numer();
                            option = obraz.sprawdz(poprawka, option);

                        }

                        break;
                    case 5:    // wyświetlanie ostatecznie zatwierdzonych danych użytkownika bez możliwości zmiany
                        {
                            obraz.Koniec();
                            option = obraz.sprawdz(poprawka, option);
                        }
                        break;

                    case 6:     // fragment odpowiedzialny za zapytanie gracza czy chce dokonać zmian
                        {
                            poprawka = obraz.fPopraw();
                            option = obraz.Catching_error(option);  // wykrywanie wyjątków i wychwytywanie ich, kiedy użytkownik poda znak lub liczbę, która nie odpowiada za żadną funkcję

                        }
                        break;

                    default:    // wykrywanie błędnie podanej wartości, podczas gdy użytkownik może zadycydować, którą daną chce zmienić 
                        {
                            obraz.Blad();
                            option = obraz.Catching_error(option);
                        }
                        break;
                }

            }

        }
    }
}
