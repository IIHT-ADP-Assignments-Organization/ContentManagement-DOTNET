using Content_Manegement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Content_Manegement.DataLayer.NHibernateConfiguration
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(Admin entity);
        System.Threading.Tasks.Task Delete(Admin entity);
        IQueryable<Admin> admin { get; }
    }
}
