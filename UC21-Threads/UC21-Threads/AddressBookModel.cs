﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookServices
{
    // Class to map the relational data base model to a entity
    public class AddressBookModel
    {
        public int contactID { get; set; }
        public int ZIP { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public long zip { get; set; }
        public long phoneNumber { get; set; }
        public string emailId { get; set; }
        public string contactType { get; set; }
        public string addressBookName { get; set; }
        public DateTime DateOfEntry { get; set; }
    }
}