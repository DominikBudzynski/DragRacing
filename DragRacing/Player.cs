﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class Player
    {
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        private List<IRaceable> vehiclesList;
        private IRaceable currVehicle;
        private int funds;
        private int experience;

        public Player()
        {
            vehiclesList = new List<IRaceable>();
            funds = 10000;
            experience = 0;
        }

        public IRaceable CurrentVehicle
        {
            get { return currVehicle; }
            set { currVehicle = value; }
        }

        public int Funds
        {
            get { return funds; }
            set { if (value > 0) funds = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public void AddCar(Car car)
        {       
            vehiclesList.Add(car);
        }

        public bool DeleteCar(Car car)
        {   
            //Rozwiazac problem usuwania pierwszego wystapienia elementu
            if (vehiclesList.Remove(car)) return true;
            else return false;
        }
    }
}
