using Ex._01.Factory;
using Ex._01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01.Repository
{
    public class RiderRepo : IRepo
    {
        public void Delete(int id)
        {
            Rider rider = RiderDP.riderList.FirstOrDefault( x => x.RiderId == id);
            RiderDP.riderList.Remove(rider);
        }

        public IEnumerable<Rider> GetAll()
        {
            return RiderDP.riderList;
        }

        public Rider GetById(int Id)
        {
            Rider rider = RiderDP.riderList.FirstOrDefault(x => x.RiderId == Id);
            return rider;
        }

        public void Insert(Rider rider)
        {
            RiderDP.riderList.Add(rider);
        }

        public void Update(Rider rider)
        {
            Rider _rider = RiderDP.riderList.FirstOrDefault(x => x.RiderId == rider.RiderId);
            if (rider.RiderName != null)
            {
                _rider.RiderName = rider.RiderName;
            }
            if (rider.Age != 0)
            {
               _rider .Age = rider.Age;
            }
         
        }
            
    }
}
