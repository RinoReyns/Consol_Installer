using System;


namespace Application_PGS
{

    /// <summary>
    /// Klasa zawierająca funkcję wypisu oraz wczytywania informacji.
    /// </summary>
    public class Interface
    {
        /// <summary>
        /// Tworzenie obiektu osoba.
        /// </summary>
        private Person osoba = new Person();

        
        /// <summary>
        /// Funkcja wyświetla zapytanie o imię i odpowiada za wczytanie tego parametru. 
        /// </summary>
        /// <returns> 
        /// Funkcja zwraca wartość, która zapewnia przejście do kolejnego kroku wprowadzania danych.
        ///</returns>
        public int Imie()
        {
            
            Console.WriteLine("Aby zatwierdzić wprowadzone dane wciśnij ENTER.\n");
            Console.WriteLine("Podaj imię: ");
            osoba.Imie = Console.ReadLine();
            Console.Clear();

            return 2;
        }

        /// <summary>
        /// Funkcja wyświetla zapytanie o nazwisko i odpowiada za wczytanie tego parametru. 
        /// </summary>
        /// <returns>  
        /// Funkcja zwraca wartość, która zapewnia przejście do kolejnego kroku wprowadzania danych.
        ///</returns>
        public int Nazwisko()
        {
            Console.WriteLine("Aby zatwierdzić wprowadzone dane wciśnij ENTER.\n");
            Console.WriteLine("Podaj nazwisko: ");
            osoba.Nazwisko = Console.ReadLine();
            Console.Clear();
           
            return 3;
        }

        /// <summary>
        /// Funkcja wyświetla zapytanie o adres zamieszkania i odpowiada za wczytanie tego parametru. 
        /// </summary>
        /// <returns>  
        /// Funkcja zwraca wartość, która zapewnia przejście do kolejnego kroku wprowadzania danych.
        ///</returns>
        public int Adres()
        {
            Console.WriteLine("Aby zatwierdzić wprowadzone dane wciśnij ENTER.\n");
            Console.WriteLine("Podaj adres zamieszkania: ");
            osoba.Adres = Console.ReadLine();
            Console.Clear();
           
            return 4;
        }

        /// <summary>
        /// Funkcja wyświetla zapytanie o numer telefonu i odpowiada za wczytanie tego parametru. 
        /// </summary>
        /// <returns>  
        /// Funkcja zwraca wartość, która zapewnia przejście do kolejnego kroku wprowadzania danych.
        ///</returns>
        public int Numer()

        {
            Console.WriteLine("Aby zatwierdzić wprowadzone dane wciśnij ENTER.\n");
            Console.WriteLine("Podaj numer telefonu: ");
            osoba.Telefon = Console.ReadLine();
            Console.Clear();

            return 6;
        }

        /// <summary>
        /// Funkcja wyświetla zapytanie o zmiany we wprowadzonych danych.
        /// </summary>
        /// <returns>  
        /// Funkcja zwraca wartość, która ustawia wartość zmiennej "poprawa" na jeden. 
        ///</returns>
        public int fPopraw()
        {
            Console.WriteLine("Jeśli chcesz poprawić, którąś z wprowadzoncyh daną wciśnij odpowiedni numer i zatwierdź przyciskiem ENTER.\n");
            Console.WriteLine("Jeśli chcesz zakończyć proces wprowadzania danych wybierz opcję 'Podsumowanie' \n");
            Console.WriteLine("\n1 - Popraw imię");
            Console.WriteLine("2 - Popraw nazwisko");
            Console.WriteLine("3 - Popraw adres zamieszkania");
            Console.WriteLine("4 - Popraw numer telefonu ");
            Console.WriteLine("5 - Podsumowanie \n");

            return 1;
        }

      
        /// <summary>
        /// Funkcja wyświetlan komunikat o błędnie podanym numerze funkcji.
        /// </summary>
        public void Blad()
        {           
                Console.WriteLine("Nie ma takiej opcji!. Wybierz jedą z poniższych opcji");
                Console.WriteLine("Aby zatwierdzić prowadzone dane wciśnij ENTER.\n");
                Console.WriteLine("\n1 - Popraw imie");
                Console.WriteLine("2 - Popraw nazwisko");
                Console.WriteLine("3 - Popraw adres zamieszkania");
                Console.WriteLine("4 - Popraw numer telefonu ");
                Console.WriteLine("5 - Podsumowanie \n");
        
        }
       
        /// <summary>
        /// Funckja wyświetla końcowe oko, wraz z wprowadzonymi wszystkimi danymi przez gracza, bez możliwości powrotu do poprzednich kroków.
        /// </summary>
        public void Koniec()
        {
            Console.WriteLine("Imię: " + osoba.Imie);
            Console.WriteLine("Nazwisko: "+ osoba.Nazwisko);
            Console.WriteLine("Adres zamieszkania: " + osoba.Adres);
            Console.WriteLine("Numer telefonu: "+ osoba.Telefon);
            Console.WriteLine("\nWciśnij dowolny przycisk, aby zakończyć program");
            Console.ReadLine();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Funkcja zostaje uaktywniona, kiedy użytkownik wyraził chęć wprowadzenia zmiany i gdy zostanie zmieniona jedna dana.
        /// Funkcja  sprawdza wartość parametru "poprawa" i zapewnia brak konieczności uzupełniania wszystkich parametrów od nowa.  
        /// </summary>
        /// <param name="poprawa">Parametr, który jest ustawiany na wartość jeden, kiedy po raz pierwszy zostaną wprowadzone wszystkie
        /// dane przez użytkownika. Jest wykorzystywany, podczas zmiany wybranego danej użytkownika. Umożliwia zmianę tylko jednej danej bez 
        /// konieczność zmiany pozostałych.
        /// </param>
        /// <param name="option">Parametr odpowiada poruszanie się pomiędzy okienkami wprowadzania danych.</param>
        /// <returns>Funkcja zwraca wartość parametru option, który jest wykorzystywany do przemieszczania się między oknami. </returns>
        public int sprawdz(int poprawa, int option)
        {
            if (poprawa == 1)
            {
                Console.Clear();
               return 6;
            }
            else

                return option;
          
        }
        
        /// <summary>
        ///  Funkcja "wyłapuje" błędnie wprowadzony parametr przez użytkownika. Uniemożliwa również wybrania opcji "6", 
        ///która formalnie istnieje w switchu, ale użytkownik nie może sie do niej odwołać.  
        /// </summary>
        /// <param name="option">Parametr odpowiada za poruszanie się pomiędzy okienkami wprowadzania danych. </param>
        /// <returns> Funkcja zwraca wartość parametru option, który jest wykorzystywany do przemieszczania się między oknami.</returns>
        /// <exception cref="ArgumentException">6</exception>
        public int Catching_error(int option)
        {
            try
            {
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 6)
                {
                    option++;
                    throw new ArgumentException("6");
                }
            }

            catch (ArgumentException x) when (x.Message == "6")
            {}

            catch (Exception )
            {
                Console.Clear();
                option = 7;
            }
            return option;
        }
    }
}
