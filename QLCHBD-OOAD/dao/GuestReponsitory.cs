﻿using QLCHBD_OOAD.model.Guest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBD_OOAD.dao
{
    class GuestReponsitory
    {
        private Db db;
        private static GuestReponsitory instance;

        public static GuestReponsitory getInstance()
        {
            if (instance == null)
            {
                instance = new GuestReponsitory();
            }           
            return instance;
        }

        private GuestReponsitory()
        {
            db = Db.getInstace();
        }

        public Guest findRentalGuestById(string id)
        {
            Guest guest = null;
            string command = $"SELECT `id`, `cmnd_cccd`, `address`, `name`, birth_date, membership FROM `guest` WHERE id = {id}";
            var reader = db.executeCommand(command);
            if (reader != null && reader.Read())
            {
                guest = new Guest((long)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (DateTime)reader[4], (bool)reader[5]);
            }
            db.closeConnection();
            return guest;
        }
        public Guest findRentalGuestByIdCard(string cardId)
        {
            Guest guest = null;
            string command = $"SELECT `id`, `cmnd_cccd`, `address`, `name`, birth_date, membership FROM `guest` WHERE cmnd_cccd = {cardId}";
            var reader = db.executeCommand(command);
            if (reader != null && reader.Read())
            {
                guest = new Guest((long)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (DateTime)reader[4], (bool)reader[5]);
            }
            db.closeConnection();
            return guest;
        }
       
        public long createGuest(Guest guest)
        {
            long resultId = -1;
            int isMember = guest.isMember ? 1 : 0;            
            string format = "yyyy-MM-dd";
            string command = $"INSERT INTO `guest`( `cmnd_cccd`, `address`, `birth_date`, `name`,`membership` ) VALUES ('{guest.cmnd}','{guest.address}','{guest.birthDate.ToString(format)}','{guest.name}','{isMember}')";            
            resultId = db.excuteInsertCommand(command);
            return resultId;
        }
        public long updateGuest(Guest guest)
        {
            long resultId = -1;
            string format = "yyyy-MM-dd";
            int isMember = guest.isMember ? 1 : 0;
            string command = $"UPDATE `guest` SET `cmnd_cccd`='{guest.cmnd}',`address`='{guest.address}',`birth_date`='{guest.birthDate.ToString(format)}',`name`='{guest.name}',`membership`='{isMember}' WHERE id = '{guest.id}'";
            try
            {
                var reader = db.executeCommand(command);
                resultId = guest.id;              
            }
            catch
            {
                resultId = -1;
            }
            return resultId;
        }
        public ObservableCollection<Guest> getAllGuest()
        {
            ObservableCollection<Guest> guests = new ObservableCollection<Guest>();
            string command = $"SELECT `id`, `cmnd_cccd`, `address`, `name`, birth_date, membership FROM `guest`";
            var reader = db.executeCommand(command);
            while (reader.Read())
            {
                Guest guest = new Guest((long)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (DateTime)reader[4], (bool)reader[5]);
                guests.Add(guest);
            }
            return guests;
        }

    }
}
