﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBD_OOAD.model.Guest
{
    public class Guest
    {
        private long _id;
        public long id
        {
            get => _id;
            set => _id = value;
        }

        private string _cmnd;
        public string cmnd { get => _cmnd; set => _cmnd = value; }

        private string _address;
        public string address { get => _address; set => _address = value; }

        private string _name;
        public string name { get => _name; set => _name = value; }

        private DateTime _birthDate;
        public String birthDateString
        {
            get => _birthDate.ToShortDateString();
        }
        public DateTime birthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public Guest() 
        {
            _cmnd = "";
            _address = "";
            _name = "";
            _birthDate = new DateTime(2005,01,01);
        }
        public Guest(long id, string cmnd, string address, string name, DateTime birthDate)
        {
            _id = id;
            _cmnd = cmnd;
            _address = address;
            _name = name;           
            _birthDate = birthDate;

        }
        public Guest(long id, string cmnd, string address, string name)
        {
            _id = id;
            _cmnd = cmnd;
            _address = address;
            _name = name;
        }

    }
}
