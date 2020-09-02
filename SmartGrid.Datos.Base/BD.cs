using SmartGrid.Datos.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace SmartGrid.Datos.Base
{

    public static class BD
    {
        public static ConcurrentDictionary<int, Person> BDPerson = new ConcurrentDictionary<int, Person>();
        public static ConcurrentDictionary<int, PersonType> BDPersonType = new ConcurrentDictionary<int, PersonType>
        {
            [1] = new PersonType() { ID = 1, Description = "Teacher" },
            [2] = new PersonType() { ID = 2, Description = "Students" },
        };
    }
}
