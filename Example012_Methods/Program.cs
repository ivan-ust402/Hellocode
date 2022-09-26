// Вид 1. Методы, которые ничего не принимают и ничего не возвращают
void Method1() {
    Console.WriteLine("Автор ...");
}

// Method1();

// Вид 2. Методы, которые принимают что-то на вход и ничего не возвращают
void Method2(string msg) {
    Console.WriteLine(msg);
}

// Method2("Текст");

void Method21(string msg, int count) {
    int i = 0;
    while (i < count) {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21(msg: "Текст сообщения", count: 4);
// Method21(count: 4, msg: "Новый текст");

// Вид 3. Методы, которые что-то возвращают, но ничего не принимают
int Method3() {
    return DateTime.Now.Year;
}

// int year = Method3();
// Console.WriteLine(year);

// Вид 3. Методы, которые что-то возвращают и что-то принимают
// string Method4(int count, string text) {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count) {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text) {
    string result = String.Empty;

    for (int i = 0; i < count; i++) {
        result = result + text;
    }

    return result;
}

string res = Method4(10, "z");
// Console.WriteLine(res);

// Задача вывода таблицы умножения на экран
for (int i = 2; i <= 10; i++) {
    for (int j = 2; j <= 10; j++) {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}