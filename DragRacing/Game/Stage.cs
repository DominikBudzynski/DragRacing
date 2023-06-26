using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragRacing.Cars;

namespace DragRacing.Game
{
    class Stage
    {
        private List<IRaceable> stageEnemies;
        private List<List<double>> stageTracks;
        private List<List<int>> trackPrizes;

        public Stage()
        {
            stageEnemies = new List<IRaceable>();
            stageTracks = new List<List<double>>();
            trackPrizes = new List<List<int>>();
        }

        public List<IRaceable> StageEnemies
        {
            get { return stageEnemies; }
            set { stageEnemies = value; }
        }

        public List<List<double>> StageTracks
        {
            get { return stageTracks; }
            set { stageTracks = value; }
        }

        public List<List<int>> TrackPrizes
        {
            get { return trackPrizes; }
            set { trackPrizes = value; }
        }


    }
}
