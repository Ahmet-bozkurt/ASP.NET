// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string msg1 = "Krediler";
int term = 12;
double amount = 100000;

Boolean isAuth = true;

Console.WriteLine(msg1);

//condition
if (isAuth == false)
{
    Console.WriteLine("Hoşgeldin");
}
else
{
    Console.WriteLine("Giriş yap");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };

string[] loans2 = new string[6];

//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new(new DapperCourseDal());

List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();

customer1.Id = 1;
customer1.NationalIdentity = "12345678901";
customer1.FirstName = "Ahmet";
customer1.LastName = "BOZKURT";
customer1.CustomerNumber = "111111";


IndividualCustomer customer2 = new IndividualCustomer();

customer2.Id = 2;
customer2.NationalIdentity = "12345678901";
customer2.FirstName = "Medine";
customer2.LastName = "BOZKURT";
customer2.CustomerNumber = "222222";


CorporateCustomer customer3 = new CorporateCustomer();

customer3.Id = 3;
customer3.Name = "Mesut";
customer3.CustomerNumber = "654";
customer3.TaxNumber = "333333";


CorporateCustomer customer4 = new CorporateCustomer();

customer4.Id = 4;
customer4.Name = "Ahmet";
customer4.CustomerNumber = "655";
customer4.TaxNumber = "444444";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer item in customers)
{
    Console.WriteLine(item.CustomerNumber);
}