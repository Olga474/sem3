Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //12345

for (int i = 1; i <= number; i++) {
    Console.Write($"{Math.Pow(i,3)} ");
}


