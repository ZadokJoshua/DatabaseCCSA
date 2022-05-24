using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

Console.WriteLine("ORM Class");

Console.WriteLine(Guid.NewGuid().ToString());

var helper = new FluentNHibernateHelper();
helper.OpenSession();


public class Customer
{
    public virtual int Id { get; set; }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string Address { get; set; }
    // 1-1 relationship
    public virtual Company Company { get; set; }

    // 1-many relationship
    public virtual List<Sales> Sales { get; set; }

    // many-many relationship
    public virtual List<Products> Products { get; set; }
}

public class CustomerMap : ClassMap<Customer>
{
    public CustomerMap()
    {
        Id(x => x.Id);// Id - creates a new column and converts the column to your primary key
        // Primary key - is a column that is unique for each rows
        // Int or GUID (globally unique identifier) are used for primary keys
        Map(x => x.FirstName); // Map -  Creates a column -- Primitive types { string, int, double, long... }
        Map(x => x.LastName);
        Map(x => x.Address);
        References(x => x.Company);
        HasMany(x => x.Sales);
        HasManyToMany(x => x.Products);
    }
}

public class Products
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual double UnitCost { get; set; } 
    public virtual List<Customer> Customer { get; set; }
}

public class Sales
{
    public virtual int Id { get; set; }
    public virtual double SalesCost { get; set; } 
    public virtual string SalesPersonnel { get; set; }
    public virtual Customer Customer { get; set; }
}

public class SalesMap : ClassMap<Sales>
{
    public SalesMap()
    {
        Id(x => x.Id);
        Map(x => x.SalesCost);
        Map(x => x.SalesPersonnel);
    }
}

public class Company
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual string Address { get; set; }
}

public class Customer2
{
    public int Id { get; set; }
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
            .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\GroupOneSchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
            .BuildSessionFactory(); 
    }

    public ISession OpenSession() //Starts the process
    {
        return SessionFactory.OpenSession();
    }
}
