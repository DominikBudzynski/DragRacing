using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragRacing.Cars;

namespace DragRacing.Game
{
    class Player
    {
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        private List<IRaceable> vehiclesList;
        private IRaceable currVehicle;
        private int funds;
        private int experience;

        //DODAC KONSTRUKTOR PARAMETRYCZNY, DODAC MOZLIWOSC USTAWIANIA NAZWY UZYTKOWNIKA
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
            //tak zeby mozna bylo posiadac wiele tych samych aut
            if (vehiclesList.Remove(car)) return true;
            else return false;
        }
    }
}
