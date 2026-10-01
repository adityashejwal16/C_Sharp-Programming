using System;


class Display
{
   static int AdditionTwoNumber(int iNo1, int iNo2)
   {
      int iSum = 0;
      iSum = iNo1 + iNo2;   // Business logic
      return iSum;
   }
    static void Main()
    {
        int iValue1 = 0, iValue2 = 0, iRet = 0;

        Console.Write("Enter the First No : ");
        iValue1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Secound No : ");
        iValue2 = Convert.ToInt32(Console.ReadLine());

        iRet = AdditionTwoNumber(iValue1,iValue2);

        Console.WriteLine("Addition is " + iRet);
    }
}