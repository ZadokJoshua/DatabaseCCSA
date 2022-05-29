using HospitalManagementSystem_LiveEvaluation2;
using HospitalManagementSystem_SecondSolution.HospitalModel;
using HospitalManagementSystem_SecondSolution.HospitalModel.Staffs;

Console.WriteLine("Hello, ORM!");

FluentNHibernateHelper.OpenSession();


using (var session = FluentNHibernateHelper.OpenSession())

{

    var hospital1 = new Hospital { Name = "Dynamic Clinic", Address = "Abuja", Website = "www.dy-clinic.com" };

    session.SaveOrUpdate(hospital1);

}

using (var session = FluentNHibernateHelper.OpenSession())

{

    var accountant = new Accountant { FirstName = "Zadok", Address = "Abuja", LastName = "Josh", MobileNumber = 0921 };

    session.SaveOrUpdate(accountant);

}