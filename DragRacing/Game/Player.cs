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
            funds = 100000;
            experience = 0;
            currVehicle = new RaceCar(70, 10, 4, 30, 20, "Lanos", 6500);
            vehiclesList.Add(currVehicle);
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

        public void AddCar(IRaceable car)
        {
            vehiclesList.Add(car);
        }

        public bool DeleteCar(IRaceable car)
        {
            //Rozwiazac problem usuwania pierwszego wystapienia elementu
            //tak zeby mozna bylo posiadac wiele tych samych aut
            if (vehiclesList.Remove(car)) return true;
            else return false;
        }

        public List<IRaceable> PlayerVehicles { get { return vehiclesList; } }
    }
}
