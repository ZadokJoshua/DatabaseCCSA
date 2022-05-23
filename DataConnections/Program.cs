using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

Console.WriteLine("ORM Class");

var helper = new FluentNHibernateHelper();
helper.OpenSession();


public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

public class CustomerMap : ClassMap<Customer>
{
    public CustomerMap()
    {
        Id(x => x.Id);
        Map(x => x.FirstName);
        Map(x => x.LastName);
        Map(x => x.Address);
    }
}

// Installed ORM - FluentNHibernate

public class FluentNHibernateHelper
{
    private ISessionFactory _sessionFactory;
    private ISessionFactory SessionFactory
    {
        get
        {
            if (_sessionFactory == null)
            {
                InitialiseSessionFactory();
            }
            return _sessionFactory;
        }
    }

    // Database all have one thing in common and that is called connection string
    public void InitialiseSessionFactory()
    {
        _sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\MyGeeDesmond.mdf;Integrated Security=True;Connect Timeout=30")
            .ShowSql())
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
            .BuildSessionFactory(); // Initialise Session Factory 
        // Data Source = Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\MyGeeDesmond.mdf;Integrated Security=True;Connect Timeout=30
    }

    public ISession OpenSession() //Starts the process
    {
        return SessionFactory.OpenSession();
    }
}