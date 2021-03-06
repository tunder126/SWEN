﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class Room
    {
        private string roomID;
        private string room_Type;
        private string bed_Type;
        private string room_Rates;
        private string vacancy;
        private string add_Remarks;
        private string room_Level;
        private string roomCapacity_People;

        public Room()
        {

        }

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string Room_Type
        {
            get { return room_Type; }
            set { room_Type = value; }
        }

        public string Bed_Type
        {
            get { return bed_Type; }
            set { bed_Type = value; }
        }

        public string Room_Rates
        {
            get { return room_Rates; }
            set { room_Rates = value; }
        }

        public string Vacancy
        {
            get { return vacancy; }
            set { vacancy = value; }
        }

        public string Add_Remarks
        {
            get { return add_Remarks; }
            set { add_Remarks = value; }
        }

        public string Room_Level
        {
            get { return room_Level; }
            set { room_Level = value; }
        }

        public string RoomCapacity_People
        {
            get { return roomCapacity_People; }
            set { roomCapacity_People = value; }
        }
    }
}
