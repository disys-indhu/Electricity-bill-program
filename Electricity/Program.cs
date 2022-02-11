using System;
public class ElectricityBill
{
    public long ConsumerNumber;
    public string ConsumerName, ConnectionType;
    public int PreviousMonthReading, CurrentMonthReading;

    public void Input()
    {
        Console.Write("Enter consumer number :\t");
        ConsumerNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter consumer name :\t");
        ConsumerName = Console.ReadLine();
        Console.Write("Enter connection type :\t");
        ConnectionType = Console.ReadLine();
        Console.Write("Enter previous month reading :\t");
        PreviousMonthReading = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter current month reading :\t");
        CurrentMonthReading = Convert.ToInt32(Console.ReadLine());
    }
    public void Bill()
    {
        int totalUnit;
        double amount = 0;
        totalUnit = CurrentMonthReading - PreviousMonthReading;
        Console.Write("----------");
        Console.Write("\n");
        Console.Write("EB BILL\n");
        Console.Write("----------");
        Console.Write("\n");
        Console.Write("Consumer number:" + ConsumerNumber);
        Console.Write("\n");
        Console.Write("Consumer name:" + ConsumerName);
        Console.Write("\n");
        Console.Write("connection type :" + ConnectionType);
        Console.Write("\n");
        Console.Write("consumption :" + totalUnit);
        Console.Write("\n");
        if (ConnectionType.Equals("domestic"))
        {
            if (totalUnit >= 0 && totalUnit <= 100)
            {
                amount = totalUnit * 1;
            }
            else if (totalUnit > 100 && totalUnit <= 200)
            {
                amount = totalUnit * 2.5f;
            }
            else if (totalUnit > 200 && totalUnit <= 500)
            {
                amount = totalUnit * 4;
            }
            else
            {
                amount = totalUnit * 6;
            }
            Console.Write("EB amount Rs." + amount);
        }
        if (ConnectionType.Equals("commercial"))
        {
            if (totalUnit >= 0 && totalUnit <= 100)
            {
                amount = totalUnit * 2;
            }
            else if (totalUnit > 100 && totalUnit <= 200)
            {
                amount = totalUnit * 4.5f;
            }
            else if (totalUnit > 200 && totalUnit <= 500)
            {
                amount = totalUnit * 6;
            }
            else
            {
                amount = totalUnit * 7;
            }
            Console.Write("EB amount Rs." + amount);


        }

    }


}
class Amount
{
    public static void Main(string[] args)
    {
        ElectricityBill e = new ElectricityBill();
        e.Input();
        e.Bill();

    }

}