using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

Console.WriteLine("ORM!");

var helper = new FluentNHibernateHelper();
helper.OpenSession();

public class FluentNHibernateHelper
{
    //The session factory links your objects/code to your database
    public ISessionFactory _sessionFactory;

    public ISessionFactory SessionFactory
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


    public void InitialiseSessionFactory()
    {
        //Fluently.Configure( ) connects your session factory to your database
        //To initialise your database you need your connection string as it gives you access to your database

        _sessionFactory = Fluently.Configure().Database(
            // Database all have one thing in common and that is called connection string
            MsSqlConfiguration.MsSql2012.ConnectionString(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30"
                )
            .ShowSql())

            //Mapping helps the database recognise which properties become the columns to use to create the table
            .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())

            //This ensures that the databse is created            
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))

            .BuildSessionFactory();


    }

    public ISession OpenSession()
    {
        return SessionFactory.OpenSession();
    }
}
