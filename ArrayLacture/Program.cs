// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// declation of array
int[] Ages = new int[5]; // data type + [] meaning array + array name = new [ count of values ]
Ages = new int[] { 10,5,100,300,50};

string CarName = "volvo";
string CarName2 = "BMW";
string CarName3 = "Hyndi";

string[] Cars = new string[] { "volvo  ", "  BMW", "  Hyndi", "  Audi  " };

#region Index
//index 0 1 2 3 4 5
//Console.WriteLine("Current value: ");
//Console.WriteLine(Cars[0]);
//Cars[0] = Console.ReadLine();
//Console.WriteLine("New value: ");
//Console.WriteLine(Cars[0]);
#endregion


//Looping 

//Console.WriteLine(CarName.Trim());
//Console.WriteLine(CarName2.Trim());
//Console.WriteLine(CarName3.Trim());
//foreach datatype name of one object from array 
foreach (string car in Cars)
{   
    //handel each object or item or value in array
    Console.WriteLine(car.Trim());//trim is a funcion to remove space from strings
}

Console.WriteLine("Count of array values: "+Cars.Length);// Count of array

int number = 1;
int newNumber = number + number;

Console.WriteLine(++number);//number = number + number; 2
                            // value = 1+1 =2
Console.WriteLine(number++);//number = number than number = number + number
                            // value = 2; value = 2+1;
Console.WriteLine(number);  //function

for (int i = 0; i < Cars.Length; i++)
{
    Console.WriteLine(i);
    Console.WriteLine(Cars[i]);
}

