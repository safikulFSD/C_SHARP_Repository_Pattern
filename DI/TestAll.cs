using Ex._01.Models;
using Ex._01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01.DI
{
    public class TestAll
    {
        public  void DisplayOptions()
        {
            Console.WriteLine("1 Show All Rider");
            Console.WriteLine("2 Insert Rider");
            Console.WriteLine("3 Update Rder");
            Console.WriteLine("4 Delete Rider");
            var index = int.Parse(Console.ReadLine());
            Show(index);

        }
        public  void Show(int index)
        {
            RiderRepo riderRepo = new RiderRepo();
            //index 1 for get all Rider data

            if (index == 1)
            {
                var riderList = riderRepo.GetAll();
                if (riderList.Count() == 0)
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("No item found in the list");
                    Console.WriteLine("=====================================");
                    DisplayOptions();
                }
                else
                {
                    foreach (var item in riderRepo.GetAll())
                    {
                        Console.WriteLine($"Rider Id :{item.RiderId}, Name :{item.RiderName}, Age :{item.Age}");
                    }
                    Console.WriteLine("================");
                    DisplayOptions();
                }
            }
            //Index 2 for insert data
            else if (index == 2)
            {
                Console.WriteLine("===================");
                Console.Write("Name :");
                string name = Console.ReadLine();

                Console.Write("Age :");
                int age = Convert.ToInt32(Console.ReadLine());

                int maxId = riderRepo.GetAll().Any() ? riderRepo.GetAll().Max(x => x.RiderId) : 0;

                Rider rider = new Rider
                {
                    RiderId = maxId + 1,
                    RiderName = name,
                    Age = age
                };
                riderRepo.Insert(rider);
                Console.WriteLine("Data Inserted successfully!!!");
                Console.WriteLine("=========================");
                DisplayOptions();

            }
            //Index 3 for update data
            else if (index == 3)
            {
                Console.WriteLine("=====================================");
                Console.Write("Entry rider id no to update : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var _rider = riderRepo.GetById(id);
                if (_rider == null)
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Rider id is invalid!!");
                    Console.WriteLine("=====================================");
                    DisplayOptions();
                    return;
                }
                else
                {
                    Console.WriteLine($"Update info for rider id :{id}");
                    Console.WriteLine("=====================================");
                    Console.Write("Name :");
                    string name = Console.ReadLine();

                    Console.Write("Age :");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Rider rider = new Rider
                    {
                        RiderId = id,
                        RiderName = name,
                        Age = age
                    };
                    riderRepo.Update(rider);
                    Console.WriteLine("Data Updated successfully!!!");
                    Console.WriteLine("=====================================");
                    DisplayOptions();
                }
            }
            ///Index 4 for delete data
            else if (index == 4)
            {
                Console.WriteLine("===================");
                Console.Write("Entry rider id no to delete : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var _rider = riderRepo.GetById(id);
                if (_rider == null)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Rider id is invalid!!");
                    Console.WriteLine("========================");
                    DisplayOptions();
                    return;
                }
                else
                {
                    riderRepo.Delete(id);
                    Console.WriteLine("Data Deleted successfully!!!");
                    Console.WriteLine("=================");
                    DisplayOptions();
                }
            }
        }
    }
}
