using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {

        //private bool isON;
        //private int currentChannel;
        //private int currentVolume;

        public bool IsOn
        {
            get;
            private set;
        }
        public int CurrentChannel
        {
            get;
            private set;
        }
        public int CurrentVolume
        {
            get;
            private set;
        }

        //contructor
        public Television()
        {
            CurrentVolume = 2;
            CurrentChannel = 3;
            IsOn = false;
        }
        //methods
        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
            //TurnOn() besides turning the tv on, also resets the channel to 3 and the volume level to 2 
        }
        public void ChangeChannel(int newChannel)
        {
            if ((IsOn == true) && (CurrentChannel >= 3 && CurrentChannel <= 18))
            {
                CurrentChannel = newChannel;
            }
            //ChangeChannel(int newChannel) changes the current channel (only if it is on) to the value of newChannel as long as it is between 3 and 18 
        }
        public void ChannelUp()
        {
            if (IsOn == true && CurrentChannel < 18)
            {
                CurrentChannel ++;
            }
            else if (IsOn == true && CurrentChannel == 18)
            {
                CurrentChannel = 3;
            }
            //ChannelUp() increases the current channel by 1 (only if it is on). If the value goes past 18, then the current channel should be set to 3. 
        }
        public void ChannelDown()
        {
            if ((IsOn == true) && (CurrentChannel > 3))
            {
                CurrentChannel -= 1;

                //ChannelDown() decreases the current channel by 1 (only if it is on). If the value goes below 3, then the current channel should be set to 18.
            }
            else if ((IsOn == true) && (CurrentChannel == 3))
            {
                CurrentChannel = 18;
            }
        }
            public void RaiseVolume()
            {
                if ((IsOn == true) && (CurrentVolume < 10))
                {
                    CurrentVolume += 1;
                }
            }
            //RaiseVolume() inceases the volume by 1 (only if it is on). The limit is 10 

            public void LowerVolume()
            {
                if ((IsOn == true) && (CurrentVolume > 0))
                {
                    CurrentVolume -= 1;
                }
            }
            //LowerVolume() decreases the volume by 1(only if it is on).The limit is 0
        }
    }

