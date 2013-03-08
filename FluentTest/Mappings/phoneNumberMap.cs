using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentTest.Entities;

namespace FluentTest.Mappings
{
    public class phoneNumberMap : ClassMap<PhoneNumber>
    {
        public phoneNumberMap()
        {
            Id(x => x.Id);
            Map(x => x.areaCode);
            Map(x => x.number);
            References(x => x.theEmployee).Column("Employee_Id");
        }
    }
}
