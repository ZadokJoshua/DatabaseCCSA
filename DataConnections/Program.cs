using FluentNHibernate.Cfg;
using NHibernate;

Console.WriteLine("ORM Class");




public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
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
        _sessionFactory = Fluently.Configure().Database(); // Initialise Session Factory 
    }
}