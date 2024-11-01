using Ex._01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01.Factory
{
    public interface IRepo
    {
        IEnumerable<Rider> GetAll();
        Rider GetById(int Id);
        void Insert(Rider rider);
        void Update(Rider rider);
        void Delete(int id);
    }
}
