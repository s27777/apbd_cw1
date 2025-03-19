// Typy danych

using Cwiczenia2.Inheritance;

{
    int number = 10;
    float floatValue = 2.4f;
    double doubleValue = 2.0;
    bool logical = false;
    char symbol = 'A';
    string text = "Hello!";

    var k = "Text";
    
    // Nullable
    int? nullableInt = null;
    nullableInt = 10;
    Object? o = null;
}

// Strings
{
    int number = 10;
    string text = "Text: " + number + ".";
    string textWithDollar = $"Text: {number}.";

    string path = "C:\\Users\\s11111\\SomeFolder";
    string textWithAtSymbol = @"C:\Users\s11111\SomeFolder";
}

// Tablice i Kolekcje
{
    int[] arr = new int[10];
    int[] arr2 = { 1, 2, 3, 4, 5 };
    
    var list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    
    var set = new HashSet<int>();
    set.Add(1);
    set.Add(2);
    set.Add(1); // wartosc nie zostanie dodana
    
    var dict = new Dictionary<int, string>();
    dict.Add(1, "1");
    dict.Add(2, "2");
    dict.Add(3, "2");
}

// Petle
{
    var list = new List<int>() {1, 2, 3, 4, 5 };

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }
    
    foreach(var item in list)
    {
        Console.WriteLine(item);
    }
}

A a = new A(1);
A b = new B(2, 2);

a.SendMessage("test");
b.SendMessage("test");
