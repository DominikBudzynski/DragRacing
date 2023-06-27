using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Game
{
    class StageHandler
    {
        //UPDATEPLAYER TRZEBA OBLICZAC DOSWIADCZENIE I HAJS
        private List<Stage> stages;
        private Player player;
        private bool ifLastWon;

        public StageHandler(List<Stage> stages)
        {
            player = new Player();
            this.stages = stages;
            ifLastWon = false;
        }

        public bool EvaluateRace(IRaceable playerVehicle, IRaceable enemyVehicle)
        {
            //TRZEBA UWZGLEDNIC DOSWIADCZENIE + BONUSY DLA KAZDEJ TRASY
            double playerTime, enemyTime;
            playerTime = playerVehicle.Accelerate(500);
            enemyTime = enemyVehicle.Accelerate(500);
            if (playerTime < enemyTime) return true;
            else if (playerTime > enemyTime) return false;
            return false;
        }

        public void UpdatePlayer()
        {
            if (ifLastWon)
            {

            }
        }
        public Player GetPlayer{ get { return player; } }
        public List<Stage> GetStages {  get { return stages; } }
    }
}
