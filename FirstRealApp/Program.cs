using FirstRealApp.Accounting;
using FirstRealApp.HR;
using System.Net.Http.Headers;
using System.Text;


IEmployee Bethany = new StoreManager("Bethany", "Smith", "Bethany.Smith@gmail.com", new DateTime(1979, 1, 16), 25 );
IEmployee George = new Manager("George", "Joanson", "George.Joanson@joanson.com", new DateTime(1984, 3, 14), 30);
IEmployee Bob = new JuniorResearcher("Bob", "Smith", "Bob.Smith@gmail.com", new DateTime(2000, 5, 15), 20);
IEmployee Kevin = new StoreManager("Kevin", "Kunda", "kevin.kunda@gmail.com", new DateTime(2001, 11, 12), 20);
IEmployee Natalie = new StoreManager("Natalie", "Kundova", "natalie.kundova@gmail.com", new DateTime(1999, 1, 15), 20);


List<IEmployee> Employees = new List<IEmployee>();
Employees.Add(Bethany);
Employees.Add(George);
Employees.Add(Kevin);
Employees.Add(Natalie);
Employees.Add(Bob);
foreach(Employee e in Employees)
{
    e.DisplayEmployeeDetails();
    e.GiveBonus();
    e.GiveCompliment();
}

//Bethany.DisplayEmployeeDetails();
//George.DisplayEmployeeDetails();
//Bob.ResearchNewPieTastes(5);
//string streetName = Bethany.Address.Street;
//Console.WriteLine(streetName);
//Bethany.GiveBonus();
//George.PerformWork(8);
//George.GiveBonus();

