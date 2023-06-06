// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1
static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

//2
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;

    foreach (int num in IntList)
    {
        sum += num;
    }

    Console.WriteLine("Sum of numbers: " + sum);

}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);

// 3
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int num in IntList)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);
Console.WriteLine(FindMax(TestIntList2));

// 4
static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredList = new List<int>();

    foreach (int num in IntList)
    {
        int squaredValue = num * num;
        squaredList.Add(squaredValue);
    }

    return squaredList;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> squaredList = SquareValues(TestIntList3);

Console.WriteLine("Squared values: " + string.Join(", ", squaredList));

// 5
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }

    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
int[] newArray = NonNegatives(TestIntArray);

Console.WriteLine("New array: " + string.Join(", ", newArray));

// 6
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> keyPair in MyDictionary)
    {
        Console.WriteLine("Key: " + keyPair.Key + " - Value: " + keyPair.Value);
    }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//7
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}
Dictionary<string, string> testDict = new Dictionary<string, string>();
testDict.Add("HeroName", "Iron Man");
testDict.Add("RealName", "Tony Stark");
testDict.Add("Powers", "Money and intelligence");
// This should print true
Console.WriteLine(FindKey(testDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(testDict, "Name"));

// 8

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        string name = Names[i];
        int number = Numbers[i];
        dictionary[name] = number;
    }
    return dictionary;
}
List<string> Names = new List<string>() { "Julie", "Harold", "James", "Monica" };
List<int> Numbers = new List<int>() { 6, 12, 7, 10 };

Dictionary<string, int> result = GenerateDictionary(Names, Numbers);
foreach (KeyValuePair<string, int> keys in result)
{
    Console.WriteLine($"Key: {keys.Key} - Value: {keys.Value}");
}

