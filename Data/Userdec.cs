using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace FlightBookingAPIs.Data

{
    public class Userdec
    {
      public  Dictionary<int,Model.User> userlist= new Dictionary<int,Model.User>();
       public  Dictionary<int,int> fl_no= new Dictionary<int,int>();
        public  Dictionary<int,int> Bk_id= new Dictionary<int,int>();
        public Dictionary<int,Model.User> check()
            {
             
            Model.User us1= new Model.User{
                BookingId=300,
                BookingDate=DateTime.Today,
                paystat = 1,
                Flight_no=1234,
                BookingStatus=true,
               Deptairname="India",
               arrairname="Australia",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                message="confirmed"
                

            };
            userlist.Add(1,us1);
             Model.User us2= new Model.User{
                BookingId=100,
                BookingDate=DateTime.Today,
                paystat=1,
                Flight_no=1235,
               BookingStatus=true,
               Deptairname="India",
               arrairname="England",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 1000.00,
                message="confirmed"
                

            };
            userlist.Add(2,us2);
             Model.User us3= new Model.User{
                BookingId=200,
                BookingDate=DateTime.Today,
                Flight_no=1230,
                paystat=2,
              BookingStatus = false,
               Deptairname="India",
               arrairname="Africa",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                message="invalid"
               

            };
            userlist.Add(3,us3);
             Model.User us4= new Model.User{
                BookingId=400,
                BookingDate=DateTime.Today,
                paystat=3,
                Flight_no=1237,
              BookingStatus= false,
               Deptairname="India",
               arrairname="Australia",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                message="Cancelled"
                
               

            };
           userlist.Add(4,us4);
         return userlist;
        }

        public Dictionary<int,int> seats()
        {
          fl_no.Add(1234,5);
          fl_no.Add(1235,5);
          fl_no.Add(1236,5);
          fl_no.Add(1237,5);
          return fl_no;
        }
        public Dictionary<int,int> cancel()
        {
         Bk_id.Add(300,1);
         Bk_id.Add(100,2);
         Bk_id.Add(200,3);
         Bk_id.Add(400,4);
          return Bk_id;

        }
    }
}