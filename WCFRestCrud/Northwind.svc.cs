using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFRestCrud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Northwind" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Northwind.svc or Northwind.svc.cs at the Solution Explorer and start debugging.
    public class Northwind : INorthwind
    {
        NORTHWNDEntities db = new NORTHWNDEntities();


        public bool AddRegion(Region region)
        {
            try
            {
                db = new NORTHWNDEntities();

                db.Regions.Add(region);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {                
                throw e;
                //return false;
            }
           


            //throw new NotImplementedException();
        }

        public void DoWork()
        {
        }


       

        public List<RegionVM> GetRegions()
        {
            try
            {
                           
            db = new NORTHWNDEntities();

                var listRegions = (from reg in db.Regions
                                   select new RegionVM
                                   {

                                       RegionID = reg.RegionID,
                                       RegionDescription = reg.RegionDescription
                                   }).ToList();



                var listOrders = (from cust in db.Customers
                    join ord in db.Orders
                    on cust.CustomerID equals ord.CustomerID
                    select new Customer
                    {
                        ContactName = cust.ContactName,
                        CustomerID = cust.CustomerID
                    }
                ).ToList();


                return listRegions;

            }
            catch (Exception)
            {
                return new List<RegionVM>();
                //throw;
            }
        }

        public string Getreststring()
        {
            return "this is  your rest string";
        }




    }


}
