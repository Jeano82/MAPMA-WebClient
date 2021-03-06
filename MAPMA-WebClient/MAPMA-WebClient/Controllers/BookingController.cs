﻿using MAPMA_WebClient.BookRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MAPMA_WebClient.ServiceLayer;

namespace MAPMA_WebClient.Controllers
{
    public class BookingController : Controller 
    { 
        public ActionResult CreateBooking( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBooking (int EmployeeID, string username, int escapeRoomID, TimeSpan BookTime, int AmountOfPeople, DateTime BDate)
        {
            BookingService bs = new BookingService();
            bs.CreateBooking(EmployeeID, username, escapeRoomID, BookTime, AmountOfPeople, BDate);
            return View();
        }

        [HttpPost]
        public ActionResult GetBooking (int escapeRoomID, string username, DateTime BDate)
        {
            BookingService bs = new BookingService();
            Booking book = bs.GetBooking(escapeRoomID, username, BDate);
            return View(book);
        }

        [HttpPost]
        public ActionResult DeleteBooking (int EmployeeID, string username, int escapeRoomID, TimeSpan BookTime, int AmountOfPeople, DateTime BDate)
        {
            BookingService bs = new BookingService();
            bs.DeleteBooking(EmployeeID, username, escapeRoomID, BookTime, AmountOfPeople, BDate);
            return View();
        }

        public ActionResult GetAllBookings() {
            BookingService bs = new BookingService();
           List<Booking> books =  bs.GetAllBookings();
            ViewBag.List = books;
            return View();
        }

    }
}