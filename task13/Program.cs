
using System.Text;

char[] arr = { 'A', 'a', 'E', 'e', 'I', 'i', 'U', 'u', 'O', 'o', 'Y', 'y' }; // Гласные буквы
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
Console.WriteLine("Result:  ");
Convert(str,arr);
void Convert(string text, char[] array) {
    bool b;
    for (int i = 0; i < str.Length; ++i)
    {
        b = false;
        for (int j = 0; j < arr.Length; ++j)
        {
            if (str[i] == arr[j]) 
            {
                Console.WriteLine((int)str[i]); // замена буквы на ёё юникод
                b = true;
            }
        }
        if (b == false) 
        {
            Random rnd = new Random();
            Console.WriteLine(arr[2 + rnd.Next() % 10]); // Замена согласной буквы на рандомную гласную
        }
    }
}
 

 
  