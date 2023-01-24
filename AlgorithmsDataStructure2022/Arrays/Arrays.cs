using AlgorithmsDataStructure2022.ADT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure2022.Arrays{

    // Arrays
    //Insertion and Deletion 



//intArray[length] = 8;
//length++;


// inserting in start of array

//for (int i = 3; i>=0; i--)
//{
//    // this is moving over all this values

//    intArray[

// Deleting last element in array

int[] newarray = new int[9];
int nlength = 0;

for (int i = 0; i < 9; i++)
{
    newarray[nlength] = i;
    nlength++;
}

//for (int i = 0; i < nlength; i++)
//{
//    Console.WriteLine(newarray[i]);


//}
//nlength--;

//for (int i = 0; i < nlength; i++)
//{
//    Console.WriteLine(newarray[i]);

//}


//Deleting first element of array

//for (int i = 1; i<nlength; i++)
//{
//    newarray[i-1] = newarray[i];

//}
//nlength--;


//Deleting 3th element everywhere in  array

//for (int i = 3; i < nlength; i++)
//{
//    newarray[i - 1] = newarray[i];

//}
//nlength--;







// try yourself
// create array with size 20 element and set length

int[] ArrayTest = new int[20];

// fill 10 blocks of memory 

int lengthTest = 0;

for (int i = 0; i < 10; i++)
{
    ArrayTest[lengthTest] = i;
    lengthTest++;
    Console.WriteLine(ArrayTest[i]);
}

// insert value 121 in end of array 
ArrayTest[lengthTest] = 121;
lengthTest++;

//delete value from and in array
lengthTest--;


//insert value in start of array
// need to move all element on 1 position to right
for (int i = lengthTest; i >= 0; i--)
{
    ArrayTest[i + 1] = ArrayTest[i];

}
ArrayTest[0] = 35;
lengthTest++;
Console.WriteLine("Insert in start");

for (int i = 0; i < lengthTest; i++)
{
    Console.WriteLine(ArrayTest[i]);
}

// delete value in start of array
for (int i = 0; i < lengthTest; i++)
{
    ArrayTest[i] = ArrayTest[i + 1];
}
lengthTest--;

Console.WriteLine("Delete from start");

for (int i = 0; i < lengthTest; i++)
{
    Console.WriteLine(ArrayTest[i]);
}

// insert on position 5 
for (int i = lengthTest; i >= 4; i--)
{
    ArrayTest[i + 1] = ArrayTest[i];
}
ArrayTest[4] = 63;
lengthTest++;

Console.WriteLine("insert on  position 5");

for (int i = 0; i < lengthTest; i++)
{
    Console.WriteLine(ArrayTest[i]);
}

// delete on position 5

for (int i = 5; i < lengthTest; i++)
{
    ArrayTest[i - 1] = ArrayTest[i];
}

lengthTest--;

Console.WriteLine("delete on  position 5");

for (int i = 0; i < lengthTest; i++)
{
    Console.WriteLine(ArrayTest[i]);
}










