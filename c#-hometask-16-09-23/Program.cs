

//task1

//static void ShowText()
//{
//    Console.WriteLine("Hello World");
//}


//Sum();


//static void Sum()
//{
//    Console.WriteLine(5+10);
//}




//ShowText();
//ShowText();
//ShowText();



//task2

//static void Sum(int num1)
//{

//    int a = 5;
//    int b = 6;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}




//task3


//int num = 100;
//Sum(num);




//static void Sum(int num1)
//{


//    int sum = num1 + 100;
//    Console.WriteLine(sum);
//}


//task4



//static void SumOfNums(int a, int b)
//{
//    int sum = a + b;
////    Console.WriteLine(sum);
////}


//int a = 50;
//int b = 100;


//SumOfNums(a, b);


//task5


//static void Sum(int m)
//{
//    int sum = 0;
//    for (int i = 0; i < m; i++)
//    {
//        sum += i;
//    }
//    Console.WriteLine(sum);
//}




//Sum(100);

//Sum(1000);


//task6


//static void GetNumsOfArray(int[] numbers)
//{
//    foreach (var item in numbers)
//    {
//        Console.WriteLine(item);
//    }
//}

//int[] nums = { 1, 2, 3, 4, 5 };

//GetNumsOfArray(nums);



//task7


//static void CheckMarried (bool isMarried, int age)
//{
//    if (isMarried)
//    {
//        Console.WriteLine("evlidir -" + age);
//    }
//    else
//    {
//        Console.WriteLine("subaydir -" + age);
//    }
//}


//static void GetAge (int age)
//{
//    bool isMarried = false;

//    CheckMarried (isMarried, age);
//}

//int age = 40;

//GetAge(age);


//task8

//static int GetNumber()
//{
//    int number = 2;
//    return number;
//}


//int result =GetNumber();

//if (result > 10) ;
//{
//    Console.WriteLine(result);
//}


//Task9


//static string Gettemp(int temp)
//{
//    if (temp > 20)
//    {
//        return "Hot";
//    }
//    else
//    {
//        return "Cold";
//    }
//}


//string result = Gettemp(30);
//Console.WriteLine(result);



//task10



//static bool IsSuccess(string employeeName)
//{
//    string[] employees = { "haci", "sarvan", "surxay" };
//    foreach (var employee in employees)
//    {
//        if (employee== employeeName)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine("Add employee name");
//string name = Console.ReadLine();   
//bool result = IsSuccess(name);
//if (result)
//{
//    Console.WriteLine("ugurludur");
//}
//else
//{
//    Console.WriteLine("ugurlu deyil");
//}


//task11


//static int GetSumOddNumbers(int a, int b)
//{
//    int sum = 0;
//    for (int i = a;i <= b; i++)
//    {
//        sum += i;
//    }
//    return sum;
//}
//int result = GetSumOddNumbers(5,15);

//Console.WriteLine(result);



//Task 12


//static void Test()
//{
//    bool isTrue = true;
//    if (true)
//    {
//        Console.WriteLine("Meryem");
//        return;
//    }

//    Console.WriteLine("false");
//}

//task13 


//static void FindOddNums(int[] nums)
//{
//    foreach (int item in nums)
//    {
//        if (item %2 ==1)
//        {
//            return;
//        }
//    }
//}

//FindOddNums(new int[] { 1, 2, 3, 4, 5 });