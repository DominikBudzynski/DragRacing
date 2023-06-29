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
                new RaceCar(80, 12, 32, 24, "Toyota Celica", 6500),
                new RaceCar(90, 14, 34, 28, "Honda Civic", 100),
                new RaceCar(100, 16, 36, 32, "Mercedes W123", 100),
                new RaceCar(110, 18, 38, 36, "Daewoo Lanos", 100)
            };            

            //track bonuses init
            List<List<double>> bonuses = new List<List<double>>();
            bonuses.Add(new List<double>() { 1.02, 1 });
            bonuses.Add(new List<double>() { 1.02, 1 });
            bonuses.Add(new List<double>() { 1.02, 1 });
            bonuses.Add(new List<double>() { 1.02, 1 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 200 });
            prizes.Add(new List<int>() { 400 });
            prizes.Add(new List<int>() { 600 });
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
                new RaceCar(120, 20, 40, 40, "Volkswagen Passat", 6500),
                new RaceCar(130, 22, 42, 44, "Daewoo Tico", 100),
                new RaceCar(140, 24, 44, 48, "Audi 80", 100),
                new RaceCar(150, 26, 46, 52, "Renault 5", 100)
            };

            //track bonuses init
            List<List<double>> bonuses = new List<List<double>>();
            bonuses.Add(new List<double>() { 1, 1 });
            bonuses.Add(new List<double>() { 1, 1 });
            bonuses.Add(new List<double>() { 1, 1 });
            bonuses.Add(new List<double>() { 1, 1 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 1200 });
            prizes.Add(new List<int>() { 1400 });
            prizes.Add(new List<int>() { 1700 });
            prizes.Add(new List<int>() { 2000 });

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
                new OffRoadCar(165, 29, 49, 58, "Ford Bronco", 6500),
                new OffRoadCar(180, 32, 52, 64, "Toyota RAV4", 100),
                new OffRoadCar(195, 35, 55, 70, "Suzuki Jimny", 100),
                new OffRoadCar(210, 38, 58, 76, "Jeep Wrangler", 100)
            };

            //track bonuses init
            List<List<double>> bonuses = new List<List<double>>();
            bonuses.Add(new List<double>() { 0.85, 1.1 });
            bonuses.Add(new List<double>() { 0.85, 1.1 });
            bonuses.Add(new List<double>() { 0.85, 1.1 });
            bonuses.Add(new List<double>() { 0.85, 1.1 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 2200 });
            prizes.Add(new List<int>() { 2500 });
            prizes.Add(new List<int>() { 2700 });
            prizes.Add(new List<int>() { 3000 });

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
                new RaceCar(225, 41, 61, 82, "Lamborghini Countach", 6500),
                new RaceCar(245, 45, 65, 90, "Pagani Zonda F", 100),
                new RaceCar(265, 49, 69, 98, "Ferrari F40", 100),
                new RaceCar(285, 53, 73, 106, "Koenigsegg Agera R", 100)
            };

            //track bonuses init
            List<List<double>> bonuses = new List<List<double>>();
            bonuses.Add(new List<double>() { 1.03, 0.96 });
            bonuses.Add(new List<double>() { 1.03, 0.96 });
            bonuses.Add(new List<double>() { 1.03, 0.96 });
            bonuses.Add(new List<double>() { 1.03, 0.96 });

            //track prizes init
            //money and exp
            List<List<int>> prizes = new List<List<int>>();
            prizes.Add(new List<int>() { 3000 });
            prizes.Add(new List<int>() { 3500 });
            prizes.Add(new List<int>() { 3700 });
            prizes.Add(new List<int>() { 4500 });

            stage.StageEnemies = enemies;
            stage.StageTracks = bonuses;
            stage.TrackPrizes = prizes;
            return stage;
        }
    }
}