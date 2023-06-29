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
        private List<Stage> stages;
        private Player player;
        private bool ifLastWon;

        public StageHandler(List<Stage> stages)
        {
            player = new Player();
            this.stages = stages;
            ifLastWon = false;
        }

        public bool EvaluateRace(int stage, int enemy)
        {
            double playerTime, enemyTime;
            if (player.CurrentVehicle != null)
            {
                playerTime = player.CurrentVehicle.Accelerate(500, stages[stage - 1].StageTracks[enemy - 1]);
                enemyTime = stages[stage - 1].StageEnemies[enemy - 1].Accelerate(500, stages[stage - 1].StageTracks[enemy - 1]);
                if (playerTime < enemyTime)
                {
                    ifLastWon = true;
                    return true;
                }
            }
            return false;            
        }

        public void UpdatePlayer(int stage, int enemy)
        {
            if (ifLastWon)
            {
                player.Funds += stages[stage - 1].TrackPrizes[enemy - 1][0];
                ifLastWon = false;                
            }            
        }
        public Player GetPlayer{ get { return player; } }
        public List<Stage> GetStages {  get { return stages; } }
    }
}

/*
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
*/