// Вид 21

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // Инкримент - это увелечение счетчика на 1. 
                 // Декримент - это уменьшение счетчика на 1.
    }
}
Method21("Текст", 4);