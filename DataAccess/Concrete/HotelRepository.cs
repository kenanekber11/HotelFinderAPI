using DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{

   
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var context=new HotelDBContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelContext = new HotelDBContext())
            {
                var deletedValue = hotelContext.Hotels.Find(id);
                hotelContext.Hotels.Remove(deletedValue);
                hotelContext.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()
        {
           using (var hotelContext=new HotelDBContext())
            {
                return hotelContext.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var context=new HotelDBContext())
            {
                return  context.Hotels.Find(id);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var db=new HotelDBContext())
            {
                db.Hotels.Update(hotel);
                db.SaveChanges();
                return hotel;
            }
        }

    }
}
