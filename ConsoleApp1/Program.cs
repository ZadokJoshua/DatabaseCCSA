
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using NHibernate;
using NHibernate.Tool.hbm2ddl;

Console.WriteLine("ORM Class");

Console.WriteLine(Guid.NewGuid().ToString());

//var helper = new FluentNHibernateHelper();
//helper.OpenSession();

// Installed ORM - FluentNHibernate and Sql.Data.Sqlcilent
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
