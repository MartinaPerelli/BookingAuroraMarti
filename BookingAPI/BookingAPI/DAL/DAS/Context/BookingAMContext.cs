﻿using BookingAPI.Models.ApartmentModels;
using BookingAPI.Models.BookingModels;
using BookingAPI.Models.CustomerModels;
using BookingAPI.Models.ReviewModels;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.DAL.DAS.Context
{
    public class BookingAMContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public BookingAMContext(DbContextOptions<BookingAMContext> options) : base(options)
        {

        }
    }
}
