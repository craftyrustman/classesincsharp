BankA bankA = new BankA();
decimal balanceA = bankA.getBalance();
Console.WriteLine("Bank A balance is: $" + balanceA);

BankB bankB = new BankB();
decimal balanceB = bankB.getBalance();
Console.WriteLine("Bank B balance is: $" + balanceB);

BankC bankC = new BankC();
decimal balanceC = bankC.getBalance();
Console.WriteLine("Bank C balance is: $" + balanceC);

public abstract class Bank
{
    public abstract decimal getBalance();
}

public class BankA : Bank
{
    public override decimal getBalance()
    {
        return 100;
    }
}

public class BankB : Bank
{
    public override decimal getBalance()
    {
        return 150;
    }
}

public class BankC : Bank
{
    public override decimal getBalance()
    {
        return 200;
    }
} 

public abstract class Bank 
{
    public decimal getBalance();
}