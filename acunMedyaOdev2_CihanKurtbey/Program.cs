
// First Requirement:


/*Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (; number > 0; number /= 10)
{
    sum += number % 10;
}
Console.WriteLine("Sum of the digits of your number: "+sum);
*/





// Second Requirement

/*
while (true)
{

    Console.WriteLine("Enter a number between 10-100 : ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number<=10 || number >= 100)
    {
        Console.WriteLine("You entered the wrong number.Try again");
    }
    else
    {
        Console.WriteLine("Congratulations you entered the correct number");
        break;
    }

*/



// Third Requiment:


/*
int[] ages = { 10, 12, 14, 18, 22, 34, 66, 72,83 };
foreach(int age in ages)
{
    
    if(age>=0 && age <= 12)
    {
        Console.WriteLine("You are in the child category. Your age is :"+age);
    }
    else if (age >= 13 && age <= 19)
    {
        Console.WriteLine("You are in the young category. Your age is :" + age);
    }
    else if (age >= 20 && age <= 64)
    {
        Console.WriteLine("You are in the adult category. Your age is :" + age);
    }
    else if (age>64)
    {
        Console.WriteLine("You are in the elderly category. Your age is :" + age);
    }

}
*/






// Fourth Requiment:

/*  
 int[] dizi = { 4, 2, 7, 4, 8, 2, 3, 7, 9, 4 };
bool[] kontrol = new bool[dizi.Length]; // Aynı elemanı tekrar yazmamak için

Console.WriteLine("Tekrar eden elemanlar:");

for (int i = 0; i < dizi.Length; i++)
{
    if (kontrol[i]) // Eğer bu eleman daha önce kontrol edildiyse atla
        continue;

    int tekrarSayisi = 1; // Kendisi 1 kez geçtiği için 1'den başlıyoruz
    for (int j = i + 1; j < dizi.Length; j++)
    {
        if (dizi[i] == dizi[j])
        {
            tekrarSayisi++;
            kontrol[j] = true; // Bu elemanı tekrar kontrol etmeye gerek yok
        }
    }

    if (tekrarSayisi > 1)
    {
        Console.WriteLine($"{dizi[i]} tekrar ediyor ({tekrarSayisi} kez)");
    }
}

*/


// Five th requiment:

/*
 string[] kelimeler = { "Merhaba", "Dünya", "CSharp", "Kod", "Programlama" };


if (kelimeler.Length == 0)
{
    Console.WriteLine("Dizi boş!");
    return;
}


string enKisa = kelimeler[0];
string enUzun = kelimeler[0];


foreach (string kelime in kelimeler)
{
    if (kelime.Length < enKisa.Length)
        enKisa = kelime;

    if (kelime.Length > enUzun.Length)
        enUzun = kelime;
}


Console.WriteLine($"En kısa kelime: {enKisa}");
Console.WriteLine($"En uzun kelime: {enUzun}");

*/



// six th requiment :


/*
Console.WriteLine("enter a sentence ");

string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');

Array.Sort(words);

Console.WriteLine("Alphabetical sorting: ");
Console.WriteLine("-----------");

foreach(var sorter in words)
{
    Console.WriteLine(sorter);
}


*/


// seven th requiment

/*
 Diziler sabit boyutludur o yüzden genişletemeyiz.
 */



// eight th requiment:

/*
 Console.WriteLine("enter a words: ");

string w1 = Console.ReadLine();
string w2 = Console.ReadLine();
string w3 = Console.ReadLine();
string w4 = Console.ReadLine();

List<string> words = new List <string>();

words.Add(w1);
words.Add(w2);
words.Add(w3);
words.Add(w4);
words.Reverse();
Console.WriteLine("Your reversed sentence: ");

foreach(var say in words)
{
    Console.WriteLine(say);
}

*/



// nine th requiment: 

/*
List<int> number = new List<int>();
Console.WriteLine(" Enter four numbers: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int n4 = Convert.ToInt32(Console.ReadLine());

number.Add(n1);
number.Add(n2);
number.Add(n3);
number.Add(n4);

float ort = ((n1 + n2 + n3 + n4) / 4);

number.Sort();
Console.WriteLine("----------");
foreach(var control in number)
{
    Console.WriteLine($" {control} ");
}


Console.WriteLine($"Avarege of your numbers: {ort}");

*/




// ten th requiment:


/*
List <int> numbers= new List<int> { 12, 3, 7, 14, 9, 19};

for (int i = numbers.Count - 1; i >= 0; i--)
{
    if (numbers[i] < 10)
    {
        numbers.RemoveAt(i);
    }
}

Console.WriteLine("Update list is : ");

foreach(var update in numbers)
{
    Console.WriteLine($"{update}");
}
*/





// eleventh requiment :
/*
List<int> grades = new List<int> { 25, 52, 49, 62, 76, 83 };

for(int i = grades.Count - 1; i >= 0; i--)
{
    if (grades[i] < 50)
    {
        grades[i] = 50;
    }
}

foreach(var update in grades)
{
    Console.WriteLine(update);
}

*/


// twelf th requiment :

// Metot belirli bir işlemi gerçekleştiren ve tekrar tekrar çağırılabilen kod bloklarıdır.


// thirteen th requiment: 

// Bir işlemi kodlarla tekrar tekrar yapmak yerine metotlardan faydalanarak kısaca yapıp işlemimizi kolaylaştırabiliriz.


// fourteen th requiment:,
// return metot sonucunda bize bir değer döndürür ama void metotlar bir değer döndürmez


// fifteen th requiment:
// oluşturduğumuz metotta () ler arasına değişken tanımlarız ve metotu çağırdığımızda bu değişkenlere değer gireriz böylelikle verdiğimiz değerleri kullanır metotta