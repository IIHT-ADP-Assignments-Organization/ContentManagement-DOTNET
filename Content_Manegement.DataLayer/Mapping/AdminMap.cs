using Content_Manegement.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.DataLayer.Mapping
{
   public class AdminMap : ClassMap<Admin>
    {
        public AdminMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);

            Map(x => x.Email);
            Map(x => x.Password);
           
            Table("admin");

        }
    }
}
