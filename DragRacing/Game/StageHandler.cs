﻿using DragRacing.Cars;
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

        public StageHandler()
        {
            player = new Player();
        }

        public bool EvaluateRace(IRaceable player, IRaceable enemyVehicle)
        {
            //rozstrzyganie kto wygrywa
            return false;
        }

        public Player GetPlayer{ get { return player; } }
    }
}