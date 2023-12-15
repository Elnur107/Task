(string username, string password) user = ("admin", "123");

        while (true)
        {
            Console.Write("İstifadeci adi: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Şifrə: ");
            string enteredPassword = Console.ReadLine();

            if (enteredUsername == user.username && enteredPassword == user.password)
            {
                Console.WriteLine("Daxil oldunuz!");
                break; 
            }
            else
            {
                Console.WriteLine("Yanlış istifadəçi adı və ya şifrə. Xahiş edirik yenidən cəhd edin.");
            }
        }
    }
}
