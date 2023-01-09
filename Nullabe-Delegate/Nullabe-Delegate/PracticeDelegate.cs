using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabe_Delegate
{
    public class PracticeDelegate
    {


        #region Predicate

        //public delegate bool CheckNums(int num);



        //public bool CheckNumByOdd(int number)
        //{
        //    return number % 2 == 1;
        //}

        //public bool CheckNumByEvven(int number) 
        //{
        //    return number % 2 ==0;
        //}

        //public void CheckDelegate()
        //{
        //    List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

        //    //Console.WriteLine(SumOfListItem(CheckNumByOdd, nums)); 

        //    nums.FindAll(m => m > 5);

        //    Console.WriteLine(SumOfListItem(m=>m>5, nums));

        //}



        //public int SumOfListItem(Predicate<int> fucn, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (fucn(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;

        //}



        //public int SumOfListByEvven(List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        #endregion





        #region Action


        //public delegate void ChangeString(string str);


        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());

        //}

        ////public void StringToLower(string word)
        ////{
        ////    Console.WriteLine(word.ToLower());

        ////}

        //public void CheckWord()
        //{
        //    //ShowWord(StringToUpper, "Aqsin");
            //ShowWord(StringToLower, "Aqsin");

            //ChangeString changeString = new ChangeString(StringToUpper);

            ////changeString += StringToLower;
            ////changeString.Invoke("Aqsin");

            //changeString += delegate (string str)
            //{
            //    Console.WriteLine(str.ToLower());
            //};

            //changeString("Cavid");


        //    Action<string> action = StringToUpper;

        //    ////action += StringToLower;

        //    action += (string str) => Console.WriteLine(str.ToLower());

        //    action("pervin");


        //}



        //public  void ShowWord(ChangeString fucn,string str)
        //{
        //    fucn(str);
        //}


        #endregion





        //public delegate int CheckString(string str,int age);


        //public int  GetStringLength(string word,int age)
        //{
        //    return word.Length;
        //}

        //public void ShowStringLength(Func<string,int,int> fucn, string text)
        //{
        //    Console.WriteLine(fucn(text,10));
        //}


        //public void ShowString()
        //{
        //    //ShowStringLength(GetStringLength, "Aqsin");

        //    Func<string, int, int> fucn = GetStringLength;
        //    fucn("Aqsin", 3);
        //}

    }
}
