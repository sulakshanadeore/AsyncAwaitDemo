internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        //M1();
        //M2();

        CallMethod();

        Console.ReadKey();
    }



    static async void CallMethod()
    {
        Task<int> task = ReturnInt();

        M2();
        int cnt = await task;
        Print(cnt);
    }
    static async Task<int> ReturnInt()
    {
        int cnt = 0;
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method1 Returning int " + cnt++);
            }
        }
        );
        return cnt;

    }

    static void M2()
    {
        for (int i = 100; i < 110; i++)
        {
            Console.WriteLine(i);

        }


    }
    static void Print(int cnt)
    {
        Console.WriteLine("Count= " + cnt);
    }

    static async Task M1()
    {
        await Task.Delay(2000);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

    }




}

