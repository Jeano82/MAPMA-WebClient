﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MAPMA_WebClient.BookRef;

namespace MAPMA_WebClient.ServiceLayer
{
    public class BookingService
    {

        public BookingService() {
        
        }

        public void CreateBooking(int EmployeeID, string username, int escapeRoomID, TimeSpan BookTime, int AmountOfPeople, DateTime BDate) {
            IBookingServices Service = new BookingServicesClient();

            Service.Create(EmployeeID, username, escapeRoomID, BookTime, AmountOfPeople, BDate);
        }

        public void DeleteBooking(int EmployeeID, string username, int escapeRoomID, TimeSpan BookTime, int AmountOfPeople, DateTime BDate) {
            IBookingServices Service = new BookingServicesClient();

            Service.Delete(EmployeeID, username, escapeRoomID, BookTime, AmountOfPeople, BDate); 
        }

        public Booking GetBooking(int escapeRoomID, string username, DateTime BDate) {
            IBookingServices Service = new BookingServicesClient();

            try {
                Booking Book = Service.Get(escapeRoomID, username, BDate);
                return Book;
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }
        }

        public List<Booking> GetAllBookings() {
            IBookingServices Service = new BookingServicesClient();

            return Service.GetAll();

        }
    }
}