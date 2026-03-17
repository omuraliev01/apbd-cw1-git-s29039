Console.WriteLine("Enter some numbers seperated by commas:");
string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("ERROR: No numbers provided!");
    return
}