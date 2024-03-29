﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTest.Entities
{
    public class Employee
    {
      public virtual int Id { get; protected set; }
      public virtual string FirstName { get; set; }
      public virtual string LastName { get; set; }
      public virtual Store Store { get; set; }
      public virtual IList<PhoneNumber> PhoneNumbers { get; set; }
    }
}
