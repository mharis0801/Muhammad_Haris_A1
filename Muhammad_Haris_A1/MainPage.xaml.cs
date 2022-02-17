using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Muhammad_Haris_A1
{
    public partial class MainPage : ContentPage
        
    {
        private Game _game;

        public MainPage()
        {
            InitializeComponent();
            StartGame();
            RestartGame();
        }

        private void StartGame()
        {
            _game = new Game();
            
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            _game.Roll();
            startMsg.Text = $"times played {_game.PlayCount}";
            Die1Veiw.Text = $"{_game.Die1}";
            Die2Veiw.Text = $"{_game.Die2}";
            turnScore.Text = $"Turn Score = {_game.TurnScore}";
            overallScore.Text = $"Overall Score = {_game.OverallScore}";

            if (_game.PlayCount == 10)
            {
                startMsg.Text = $"Game is over! Your overall score is {_game.OverallScore} points";
                _game.Restart();
                
            }
            else
                return;

        }

        public void RestartGame()
        {
            

        }
    }
}
