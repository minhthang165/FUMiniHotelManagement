﻿using BusinessObject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BookingReservation
    {
        public int BookingReservationID { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerID { get; set; } 
        public BookingStatus BookingStatus { get; set; }
        public Customer Customer { get; set; } 
        public List<RoomInformation> BookedRooms { get; set; }

        public BookingReservation(int bookingReservationID, DateTime bookingDate, decimal totalPrice, int customerID, 
            BookingStatus bookingStatus, Customer customer, List<RoomInformation> bookedRooms)
        {
            BookingReservationID = bookingReservationID;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
            CustomerID = customerID;
            BookingStatus = bookingStatus;
            Customer = customer;
            BookedRooms = bookedRooms;
        }

        public BookingReservation() { }

        public BookingReservation(int bookingReservationID, DateTime bookingDate, decimal totalPrice, BookingStatus status, string customerFullName)
        {
            BookingReservationID = bookingReservationID;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
            BookingStatus = status;
            Customer customer = new Customer();
            customer.CustomerFullName = customerFullName;
        }

        public BookingReservation(int bookingReservationID, DateTime bookingDate, decimal totalPrice, BookingStatus status, int customerId)
        {
            BookingReservationID = bookingReservationID;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
            BookingStatus = status;
            CustomerID = customerId;
        }


        //public override string? ToString()
        //{
        //    return  $"Booking ID: {BookingReservationID}, " +
        //            $"Date: {BookingDate.ToShortDateString()}, " +
        //            $"Customer: {Customer.CustomerFullName}, " +
        //            $"Total Price: {TotalPrice:C}, " + 
        //            $"Status: {BookingStatus}";
        //}
    }
}
