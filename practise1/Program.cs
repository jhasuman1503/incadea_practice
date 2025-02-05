//1.difference between value type and reference type 


//value type

//1.It contains the actual value(data) that is to be stored .
//2.It is stored in stack data structures.
//3.It is often more efficiet and takes less space.
//4.It has limited length.
//5.Eg - int a =10;

//Reference type

//1.It contains the pointers to the variable which contains the actual data.
//2.It is stored in Heap data structures.
//3.It is less efficient and takes more space.
//4.It can have variable length.
//5.Eg - string s = "suman";


//2.What are the differences between float, double, and decimal? Give a scenario where each should be used

//float

//1. It has size of 4 byte.
//2. It can store values upto 7 decimal  place precision.
//3. It is used in scenario where there is a need of less precision calculation.
//4.Eg - float s = 1.9987f;

//Double 

//1.Ut has size of 8 byte.
//2.It contains values upto 16 place precesion.8b
//3.It is generally used in scientific calculations
//4.Eg - double d = 1.9086566543d;

//Decimal

//1.It is generally slower than float and double
//2.It has size of 16 byte.
//3.It has precision upto 28 decimal places.
//4. Eg - decimal dm = 2.7897345678956m;


//3.Write a C# program to demonstrate the use of byte, short, int, and long. Print their size and range using sizeof().


    
    
        byte b = 2;
        short s = 3;
        int i = 23;
        long l = 234;

        // using the data types

        int sum = b + s;
        Console.WriteLine(sum); 
        Console.WriteLine(b*s);

        //size

        Console.WriteLine("the size of byte is " + sizeof(byte));
        Console.WriteLine("the size of byte is " + sizeof(short));
        Console.WriteLine("the size of byte is " + sizeof(int));
        Console.WriteLine("the size of byte is " + sizeof(long));

        //range

        Console.WriteLine($"The range of the byte is{byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"The range of the byte is{short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"The range of the byte is{int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"The range of the byte is{long.MinValue} to {long.MaxValue}");




   

//4.Explain the difference between var and dynamic in C#.

//var

//1. It is used to define the variable whose datatype is defined at compile time.
//2. The data tyepe once assigned cant  be changed later.
//3. However the value of the varible can be changed in within same datatype.
//4. the variable should be declared and initialized aswell.

//dynamic

//1. It is used to define variable whose datatype is defined at runtime.
//2. The datatype can be changed after declaration also.
//3. It provides more flexibility in coding.


//5.Write some complex statements where it uses arithmetic , logical, comparision and assignment operators.


        int a = 10;
        int u = 20;
        float f  = 1.6779f;
        double d = 50.234567;

        Console.WriteLine($"The addition of a and b is {a + b} \n The subtraction of a and b is {b - a} \n The multiplication of a and b is {a * b}\n The modulus of a and b is {a % b}");

        Console.WriteLine(a>u);
        Console.WriteLine((a < u) && (f > d));
        Console.WriteLine((f<d) || (a > d));
        return;
  