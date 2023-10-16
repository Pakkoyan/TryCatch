namespace TryCatch.model;

// Задание 3
static class MyClass
{
    public static void method1()
    {
        throw new Exception("Тут что то стряслось");
    }

    public static void method2()
    {
        try
        {
            method1();
        }
        catch (Exception ex)
        {
            Console.WriteLine("WARING: " + ex);
            Console.WriteLine("Ошибка обработанна ");
        }
        
    }
}