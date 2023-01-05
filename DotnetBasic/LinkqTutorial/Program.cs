using LinqTutorial.Model;

namespace LinqTutorial;

public class ProgramMain
{
    public static void Main()
    {
        //Product.SampleFilterProduct();
        //Category.SampleFilterCategory();
        Product.SampleFilterByName();
    }

    #region Introduction
    public static void IntroductionLinq()
    {
        Console.WriteLine("Introduction without LinQ : ");
        IntroLinq.Introduction();
        Console.WriteLine("\n Intro with Linq");
        IntroLinq.IntroductionWithLinq();
    }
    #endregion
}
