using System;
using System.Threading;


namespace CrossLaneGame.GameModel
{
    class GameData //int score, int current time(ticks)
    {
        private int _score;
        private int _currentTime = 0;
        //  private int _currentGameTick;
        private Hero _hero;
        public GameData(Hero hero)
        {
            _hero = hero;
            GiveTime();
        }
        private int GiveTime()
        {
            int temp = _currentTime;
            for (int i = 0; i < 254; i++)
            {
                temp = temp + i ;
            }
            return temp;
           
        }
        public string GiveScore()
        {

            string number = "";
            if (_hero.Position.YPosition >= 7)
            {
                number = Convert.ToString(_score = GiveTime() + 3);
                return number;
            }
            if (_hero.Position.YPosition >= 5 || _hero.Position.YPosition < 7)
            {
                number = Convert.ToString(_score = GiveTime() + 2);
                return number;
            }
            if (_hero.Position.YPosition >= 3 || _hero.Position.YPosition < 5)
            {
                number = Convert.ToString(_score = GiveTime() + 1);
                return number;
            }
            return number;
        }
    }
}
