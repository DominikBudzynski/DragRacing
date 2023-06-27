using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Game
{
    class StageInitializer
    {
        public Stage InitStage(int mlp)
        {
            Stage stage = new Stage();
            //stage enemies init
            List<IRaceable> enemies = new List<IRaceable>() {
                new RaceCar(mlp * 70, mlp * 10, 4, mlp * 30, mlp * 20, "Lanos", 6500),
                new RaceCar(mlp * 100, mlp * 100, 4, mlp * 100, mlp * 100, "LANOS2", 100),
                new RaceCar(mlp * 100, mlp * 100, 4, mlp * 100, mlp * 100, "LANOS3", 100),
                new RaceCar(mlp * 100, mlp * 100, 4, mlp * 100, mlp * 100, "LANOS4", 100)
            };            

            //track bonuses init
            List<List<int>> bonuses = new List<List<int>>();
            bonuses.Add(new List<int>() { mlp * 100, mlp * 100 });
            bonuses.Add(new List<int>() { mlp * 100, mlp * 100 });
            bonuses.Add(new List<int>() { mlp * 100, mlp * 100 });
            bonuses.Add(new List<int>() { mlp * 100, mlp * 100 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { mlp * 100, mlp * 100 });
            prizes.Add(new List<int>() { mlp * 100, mlp * 100 });
            prizes.Add(new List<int>() { mlp * 100, mlp * 100 });
            prizes.Add(new List<int>() { mlp * 100, mlp * 100 });
            
            stage.StageEnemies = enemies;
            stage.StageTracks = bonuses;
            stage.TrackPrizes = prizes;
            return stage;
        }
    }
}


/*
class Track
    {
        private IRaceable stageEnemy;
        private int trackBonus;
        private int trackPrize;

        public Track(IRaceable stageEnemy, int trackBonus, int trackPrize)
        {
            this.stageEnemy = stageEnemy;
            this.trackBonus = trackBonus;
            this.trackPrize = trackPrize;
        }

        public IRaceable StageEnemy
        {
            get { return stageEnemy; }
            set { stageEnemy = value; }
        }

        public int TrackBonus
        {
            get { return trackBonus; }
            set { trackBonus = value; }
        }

        public int TrackPrize
        {
            get { return trackPrize; }
            set { trackPrize = value; }
        }
    }
*/