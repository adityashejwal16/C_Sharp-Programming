using System;

class FloatProgram
{
    static float AdditionTwoNo(float fNo1, float fNo2)
    {
        float fSum = 0.0f;
        fSum = fNo1 + fNo2;
        return fSum;
    }

    static void Main()
    {
        float fValue1 = 0.0f, fValue2 = 0.0f, fRet = 0.0f;

        Console.Write("Enter The First No :");
        fValue1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter Your Secound No :");
        fValue2 = Convert.ToSingle(Console.ReadLine());

        fRet = AdditionTwoNo(fValue1, fValue2);

        Console.WriteLine("Addition is : " + fRet);

    }
}