﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AddressBook
{
    public class AddressBookModel
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string name { get; set; }

        public string contact_type { get; set; }
    }
}
