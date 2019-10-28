﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using Engine.Models;
using Engine.Tools;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class Logic : BaseNotificationClass
    {
        private WildMagic _CurrentResult;
        public WildMagic CurrentResult
        {
            get { return _CurrentResult; }
            set
            {
                _CurrentResult = value; OnPropertyChanged();
            }
        }

        public WildMagic Roll()
        {
            int roll = RandomNumberGenerator.NumberBetween(1, 5);
            return CurrentResult = TableFactory.GetResult(roll);
        }

        public WildMagic ManualRoll(int manualRoll)
        {


            // Check if roll is Odd, and add 1 in that case. This is to align with our 1-50 table.
            if (manualRoll % 2 != 0)
            {
                manualRoll++;
            }
            int Roll = manualRoll / 2;
            return CurrentResult = TableFactory.GetResult(Roll);
        }
    } 
}
