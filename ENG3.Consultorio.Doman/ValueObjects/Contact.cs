﻿using ENG3.Consultorio.Doman.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.ValueObjects
{
    public class Contact
    {
        public int Id { get; set; }
        public string ContactValue { get; set; }
        public PhoneTypeEnum Type { get; set; }


    }
}
