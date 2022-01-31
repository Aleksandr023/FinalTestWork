string [] startArray = {"привет", "текст", "three", "три", "на", "о", "if", "for"};
string [] finalArray = new string [0];

for (int i = 0; i < startArray.Length; i++)
{
    int j = 0;
    if (startArray[i].Length < 4)
    { 
        Array.Resize(ref finalArray, j + 1);
        finalArray[j] = startArray[i];
    }
    Console.Write(String.Join(" ", finalArray));
}