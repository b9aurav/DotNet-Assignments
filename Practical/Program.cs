using System.Linq;
public class Customer {
    public string customerID {
        get;
        set;
    }

    public string city {
        get;
        set;
    }

    public Customer(String customerID, String city) {
        this.customerID = customerID;
        this.city = city;
    }

    public override string ToString() {
        return customerID + "\t" + city;
    }
    public static void getCustomers(List<Customer> customers) {
        var CustQuery = from cust in customers
                        .AsEnumerable()
				        select cust;
        printData(CustQuery);
    }

    public static void printData(IEnumerable<Customer> query) {
        foreach (Customer data in query) {
            Console.WriteLine(data.customerID + "\t" + data.city);
        }
    }

    public static void from(String city, List<Customer> customers) {
        var custQuery = from cust in customers
				 where cust.city == "London"
				 select cust;
        printData(custQuery);
    }

    public static int count(List<Customer> customers) {
        var CustQuery = from cust in customers
                        .AsEnumerable()
				        select cust;
        return CustQuery.Count();
    }

    public static void startFrom(char startingChar, List<Customer> customers) {
        var CustQuery = from cust in customers
				 where cust.customerID.StartsWith(startingChar)
				 select cust;
        printData(CustQuery);
    }
}

public class MainClass {
    public static void Main() {
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer("A01", "London"));
        customers.Add(new Customer("A02", "New York"));
        customers.Add(new Customer("A03", "Delhi"));
        customers.Add(new Customer("B01", "Delhi"));
        customers.Add(new Customer("B02", "London"));
        customers.Add(new Customer("B03", "London"));
        customers.Add(new Customer("C01", "Delhi"));
        customers.Add(new Customer("C02", "London"));
        customers.Add(new Customer("C03", "New York"));
        customers.Add(new Customer("D01", "Delhi"));
        Console.WriteLine("All Customers : \n");
        Customer.getCustomers(customers);
        Console.WriteLine("\nCustomers from London : \n");
        Customer.from("London", customers);
        Console.WriteLine("\nTotal Customers : " + Customer.count(customers));
        Console.WriteLine("\nCustomer ID starts with 'A' : \n");
        Customer.startFrom('A', customers);
    }
}