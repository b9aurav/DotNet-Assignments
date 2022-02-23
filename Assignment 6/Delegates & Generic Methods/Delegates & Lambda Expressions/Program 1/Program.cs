public delegate void WatchBalance(double n);

class Program {

    public static void checkBalance(double bal) {
        if(bal < 0) {
            Console.WriteLine("You are overdrawn");
        } else if (bal < 10) {
            Console.WriteLine("Your account balance is very low");
        } else if (bal < 100) {
            Console.WriteLine("Watch your spending carefully.");
        } else {
            Console.WriteLine("You have over $100 in your account");
        }
    }

    static void Main() {

        WatchBalance watch = checkBalance;
        ATM ac1 = new ATM(1111,"Gaurav",-100);
        Console.WriteLine("Hello, " + ac1.account_holder_name + " your current balance is " + ac1.avaliable_balance);
        watch(ac1.avaliable_balance);

        Console.WriteLine("________________________________________________________________");

        ATM ac2 = new ATM(2222,"Tushar",400);
        Console.WriteLine("\nHello, " + ac2.account_holder_name + " your current balance is " + ac2.avaliable_balance);
        watch(ac2.avaliable_balance);

        Console.WriteLine("________________________________________________________________");

        ATM ac3 = new ATM(3333,"Harsh",10);
        Console.WriteLine("\nHello, " + ac3.account_holder_name + " your current balance is " + ac3.avaliable_balance);
        watch(ac3.avaliable_balance);
    }
}