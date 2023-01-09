
#region Nullabe

//using Nullabe_Delegate;

//string name = null;


////if (name == null)
////{
////    Console.WriteLine("ddddd");
////}

//int? m = null;

////int? m = 5;

//GetPersinById(m);


//static void GetPersinById(int? id)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Notfound");
//    }


//}

#endregion


using Nullabe_Delegate;
using Nullabe_Delegate.Exceptions;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

//PracticeDelegate calculate = new();


//calculate.CheckDelegate();

//Console.WriteLine();

//calculate.CheckWord();

//calculate.ShowString();

//int m = 5;

//int n = 0;

//var res = m / n;

//Console.WriteLine(res);

//int[] arr = { 1, 2, 3 };

//arr[5] = 100;

//try
//{

//    int m = 5;

//    int n = 0;

//    var res = m / n;

//    Divide(m, n);

//    //int[] arr = { 1, 2, 3 };

//    //arr[5] = 100;


//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}


//Divide(5, 1);


//static void Divide(int m, int n)
//{

//    bool isSuccess = false;
//    try
//    {
//        //int[] arr = { 1, 2, 3 };

//        //arr[5] = 100;


//        var result = n / m;
//        isSuccess = true;
//        Console.WriteLine(result);
//    }
//    catch (IndexOutOfRangeException ex)
//    {

//        Console.WriteLine(ex.Message);

//        isSuccess = false;
//    }
//    finally
//    {
//        string massage = string.Empty;
//        if (isSuccess)
//        {
//            massage = "Register is ok";
//        }
//        else
//        {
//            massage = "Something is wrong";
//        }

//        SendEmail(massage);

//    }




//}


//static void SendEmail(string massage)
//{
//    Console.WriteLine(massage);
//}


//Login("pervin123", "pervin12345");

//static void Login(string username, string password)
//{

//	try
//	{
//		if (username == "pervin123" && password == "pervin12345")
//		{
//			Console.WriteLine("Login is success");
//		}
//		else
//		{
//			throw new InvalidCastException(ExceptionMessages.InvalidLogin);
//		}


//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}



//}


//IEmployeeService employeeService = new EmployeeService();

//employeeService.GetCountByAge(23);




