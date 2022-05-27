using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using HospitalManagementSystem_LiveEvaluation2;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

Console.WriteLine("ORM!");

FluentNHibernateHelper.OpenSession();

