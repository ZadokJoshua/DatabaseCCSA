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

            Doctor doc = new Doctor() { EmployeeID = 1, Name = "Isaac", gender = 'F', PhoneNo = "07052511362" };

            List<Patient> patients = new List<Patient>();

            for (int i = 0; i < 10; i++)
            {
                patients.Add(new Patient() { Name = "Isaac", Condition = "Critical", gender = 'm', ID = i, HospitalNumber = i + 1234, regStatus = true, phoneNo = "07054321", netWorth = 1000000 }); ;
                if ((i % 2) != 0)
                {
                    patients[i].regStatus = false;
                }
                FluentNHibernateHelper.saveData(patients[i]);
            }