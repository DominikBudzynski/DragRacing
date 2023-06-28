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
        public Stage InitStage1()
        {
            Stage stage = new Stage();
            //stage enemies init
            List<IRaceable> enemies = new List<IRaceable>() {
                new RaceCar(80, 12, 4, 32, 24, "Toyota Celica", 6500),
                new RaceCar(90, 14, 4, 34, 28, "Honda Civic", 100),
                new RaceCar(100, 16, 4, 36, 32, "Mercedes W123", 100),
                new RaceCar(110, 18, 4, 38, 36, "Daewoo Lanos", 100)
            };            

            //track bonuses init
            List<List<int>> bonuses = new List<List<int>>();
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 100 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 100 });
            prizes.Add(new List<int>() { 200 });
            prizes.Add(new List<int>() { 500 });
            prizes.Add(new List<int>() { 1000 });
            
            stage.StageEnemies = enemies;
            stage.StageTracks = bonuses;
            stage.TrackPrizes = prizes;
            return stage;
        }
        public Stage InitStage2()
        {
            Stage stage = new Stage();
            //stage enemies init
            List<IRaceable> enemies = new List<IRaceable>() {
                new RaceCar(120, 20, 4, 40, 40, "Lanos1", 6500),
                new RaceCar(130, 22, 4, 42, 44, "LANOS2", 100),
                new RaceCar(140, 24, 4, 44, 48, "LANOS3", 100),
                new RaceCar(150, 26, 4, 46, 52, "LANOS4", 100)
            };

            //track bonuses init
            List<List<int>> bonuses = new List<List<int>>();
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 00 });
            bonuses.Add(new List<int>() { 100, 100 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });

            stage.StageEnemies = enemies;
            stage.StageTracks = bonuses;
            stage.TrackPrizes = prizes;
            return stage;
        }
        public Stage InitStage3()
        {
            Stage stage = new Stage();
            //stage enemies init
            List<IRaceable> enemies = new List<IRaceable>() {
                new RaceCar(165, 29, 4, 49, 58, "Lanos1", 6500),
                new RaceCar(180, 32, 4, 52, 64, "LANOS2", 100),
                new RaceCar(195, 35, 4, 55, 70, "LANOS3", 100),
                new RaceCar(210, 38, 4, 58, 76, "LANOS4", 100)
            };

            //track bonuses init
            List<List<int>> bonuses = new List<List<int>>();
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 00 });
            bonuses.Add(new List<int>() { 100, 100 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });

            stage.StageEnemies = enemies;
            stage.StageTracks = bonuses;
            stage.TrackPrizes = prizes;
            return stage;
        }
        public Stage InitStage4()
        {
            Stage stage = new Stage();
            //stage enemies init
            List<IRaceable> enemies = new List<IRaceable>() {
                new RaceCar(225, 41, 4, 61, 82, "Lanos1", 6500),
                new RaceCar(245, 45, 4, 65, 90, "LANOS2", 100),
                new RaceCar(265, 49, 4, 69, 98, "LANOS3", 100),
                new RaceCar(285, 53, 4, 73, 106, "LANOS4", 100)
            };

            //track bonuses init
            List<List<int>> bonuses = new List<List<int>>();
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 100 });
            bonuses.Add(new List<int>() { 100, 00 });
            bonuses.Add(new List<int>() { 100, 100 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });
            prizes.Add(new List<int>() { 100, 100 });

            stage.StageEnemies = enemies;
            stage.StageTracks = bonuses;
            stage.TrackPrizes = prizes;
            return stage;
        }
    }
}