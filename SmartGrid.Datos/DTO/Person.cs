using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGrid.Datos.DTO
{
    ///<summary>
    ///Clase Person
    ///</summary>
    ///<remarks>
    ///</remarks>
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int Type { get; set; }

        public Person()
        {

        }

    }
}
