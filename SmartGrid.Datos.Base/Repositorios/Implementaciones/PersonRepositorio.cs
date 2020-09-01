using SmartGrid.Datos.Base.Repositorios.Definiciones;
using SmartGrid.Datos.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGrid.Datos.Base.Repositorios.Implementaciones
{
    public class PersonRepositorio : IPersonRepositorio
    {

        public PersonRepositorio()
        {
        }

        public Person Create(Person entity)
        {
            var max = BD.BDPerson.Values.Any() ? BD.BDPerson.Aggregate((l, r) => l.Key > r.Key ? l : r).Key : 0;
            int Id = max + 1;
            entity.ID = Id;
            bool result = BD.BDPerson.TryAdd(Id, entity);
            return entity;
        }

        public bool Delete(int Id)
        {
            Person entity;
            bool result = BD.BDPerson.TryRemove(Id, out entity);
            return result;
        }

        public List<Person> Get()
        {
            var values = new List<Person>(BD.BDPerson.Values);
            return values;
        }

        public Person Update(int Id, Person entity)
        {

            Person entityUpd;
            bool returnTrue = BD.BDPerson.TryGetValue(Id, out entityUpd);
            Delete(Id);
            entity.ID = Id;
            entity = Create(entity);
            return entity;
        }
    }
}
