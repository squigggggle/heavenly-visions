﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heavenly_visions
{
    public class AddCustomer
    {
        private string userName;
        private string tourSelection;

     
     public AddCustomer(string userName, string tourSelection) 
        {

        this.userName = userName;
        this.tourSelection = tourSelection;
        
        }

        public string UserName { get => userName; set => userName = value; }
        public string TourSelection { get => tourSelection; set => tourSelection = value; }

        public static void addName(string name)
        {
          List<string> userName = new List<string>();
          userName.Add(name);


        }
        public static void addTour(int tourID) 
        {
          List<int> tourSelection = new List<int>();
            tourSelection.Add(tourID);
        }
        
               

    }
}