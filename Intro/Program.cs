using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using Intro.Entitiess;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "14234567823";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "14234567824";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "123458";
customer3.TaxNumber = "1234567897";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer3.Id = 4;
customer3.Name = "Abc";
customer3.CustomerNumber = "123459";
customer3.TaxNumber = "1234567898";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (var item in customers)
{
    Console.WriteLine(item.CustomerNumber);
}

CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.GetAll();