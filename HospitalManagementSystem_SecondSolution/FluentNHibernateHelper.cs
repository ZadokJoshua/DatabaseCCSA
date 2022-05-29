using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace HospitalManagementSystem_LiveEvaluation2
{
        public class FluentNHibernateHelper
        {
            //The session factory links your objects/code to your database
            public static ISessionFactory _sessionFactory;
            public static ISessionFactory SessionFactory
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
            public static void InitialiseSessionFactory()
            {
                //Fluently.Configure( ) connects your session factory to your database
                //To initialise your database you need your connection string as it gives you access to your database
                _sessionFactory = Fluently.Configure().Database(
                    // Database all have one thing in common and that is called connection string
                    MsSqlConfiguration.MsSql2012.ConnectionString(
                        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HospitalModelSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30"
                        )
                    .ShowSql())
                    .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())          
                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                    .BuildSessionFactory();
            }
            public static ISession OpenSession()
            {
                return SessionFactory.OpenSession();
            }

        //public static void saveData<T>(T model)
        //{
        //    var session = FluentNHibernateHelper.OpenSession();
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        session.Save(model);
        //        transaction.Commit();
        //    }
        //}

        //public static void updateData<T>(T model)
        //{
        //    var session = OpenSession();
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        session.Update(model);
        //        transaction.Commit();
        //    }
        //}

        //public static void deleteData<T>(T model)
        //{
        //    var session = OpenSession();
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        session.Delete(model);
        //        transaction.Commit();
        //    }
        //}
    }
    }
