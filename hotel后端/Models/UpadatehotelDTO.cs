﻿using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Models
{
    public class UpdateHotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
     
    }

}
