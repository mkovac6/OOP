﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Models
{
    public class PlayerData : IComparable<PlayerData>
    {
       

        //tu ide klasika c# get, set, override za igrače
        public string PlayerName { get; set; }
        public string PicturePath { get; set; }
        public int Result { get; set; }
        public PlayerData(string name, string imgPath)
        {
           PlayerName = name;
           PicturePath = imgPath;
           Result = 0;
        }

        public int CompareTo(PlayerData other)
        {
            return -Result.CompareTo(other.Result);
        }

        public override string ToString() => $"{PlayerName} - {Result}";
        
    }
}
