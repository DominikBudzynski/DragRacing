﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Nowy_folder
{
    class MenuState : GameState
    {

        public MenuState(Game game) : base(game) { }

        public override void EnterButton()
        {
            ;
        }

        public override void ESCButton()
        {
            ;
        }

        public override void DigitOne()
        {
            parentApp.ChangeState(new SeeProfileState(parentApp));
        }

        public override void DigitTwo()
        {
            parentApp.ChangeState(new StageChoiceState(parentApp));
        }

        public override void DigitThree()
        {
            parentApp.ChangeState(new MainShopState(parentApp));
        }

        public override void DigitFour()
        {
            ;
        }
    }
}
