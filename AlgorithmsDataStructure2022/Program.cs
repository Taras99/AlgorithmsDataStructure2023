using AlgorithmsDataStructure2022.Queue;
using AlgorithmsDataStructure2022.HashTable


int[] IntArray = {-52,-32,-26, -5, 2, 3, 16, 32, 68, 74};

Console.WriteLine(BinarySearch(IntArray, 20));



int BinarySearch(int[] IntArray, int value)
{
    int start = 0;
    int end = IntArray.Length;
    
    while (start< end)
    {
       int midpoint = (start+end)/2;

        if (IntArray[midpoint] == value)
        {
            return midpoint;
        }

        else if (IntArray[midpoint] < value)
        {
            start = midpoint + 1;
        }
        else 
        {
            end = midpoint;
        }
    }
    return -1;

}

HashTable H1 = new HashTable();
H1.Set("Petro", "12");






