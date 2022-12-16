Console.Write("Ведите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); //12345

if (number / 10000 == number % 10) {
    if ((number % 100) /10 == (number % 10000) / 1000) {
        Console.WriteLine($"Число {number} является полиндромом");
    } else {Console.WriteLine($"Число {number} не является полиндромом");}
} else {Console.WriteLine($"Число {number} не является полиндромом");}
