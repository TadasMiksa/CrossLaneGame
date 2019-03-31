using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.Screens
{
    class GameOverScreen : Window //menu screen
    {
        private Button _startButton;
        private Button _quitButton;
        private TextBlock _gameTitle;
        private List<Button> _buttons = new List<Button>();
        private bool StartIsPressed = false;
        private bool QuitIsPressed = false;

        public GameOverScreen() : base(0, 0, 40, 10, '*', "GAME OVER")
        {
            _gameTitle = new TextBlock(0, 2, Width - 2, "", "YOU LOSE", "Press P to play again", "Press Q to quit");

            _buttons.Add(_startButton = new Button(2, 6, 7, 2, " PLAY", 0));
            _startButton.SetNotActive();

            _buttons.Add(_quitButton = new Button(30, 6, 7, 2, " QUIT", 1));
            _quitButton.SetNotActive();
        }

        public void ShowPlayButton()
        {
            if (StartIsPressed == false)
            {
                QuitIsPressed = false;
                buttonas(1).SetNotActive();
                buttonas(1).Render();
                StartIsPressed = true;
                buttonas(0).SetActive();
                buttonas(0).Render();
            }
        }
        public void ShowQuitButton()
        {
            if (QuitIsPressed == false)
            {
                QuitIsPressed = true;
                buttonas(1).SetActive();
                buttonas(1).Render();
                StartIsPressed = false;
                buttonas(0).SetNotActive();
                buttonas(0).Render();
            }
        }
        public int EnterPressing()
        {
            if (StartIsPressed == true)
            {
                return 0;
            }
            else if (QuitIsPressed == true)
            {
                return 1;
            }
            return 3;
        }
        public Button buttonas(int buttonId)
        {
            foreach (Button button in _buttons)
            {
                if (button.ButtonId() == buttonId)
                {
                    return button;
                }
            }
            return null;
        }


        public override void Render() //do while reikia
        {

            base.Render();
            _gameTitle.Render();
            foreach (Button button in _buttons)
            {
                button.Render();
            }

        }

    }

}
