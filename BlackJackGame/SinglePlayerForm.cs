using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BlackJackGame
{
    public partial class SinglePlayerForm : Form
    {
        private CardImages cardImages;
        private Player player;
        private Player dealer;
        private Deck deck;
        private int wins = 0;
        private int losses = 0;

        public SinglePlayerForm()
        {
            InitializeComponent();
            cardImages = new CardImages(); 
            player = new Player("Player"); 
            dealer = new Player("Dealer"); 
            deck = new Deck();

            this.FormClosing += SinglePlayerForm_FormClosing;

        }
        private void SinglePlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private async void SinglePlayerForm_Load(object sender, EventArgs e)
        {
            deck.Shuffle(); 
            await Task.Delay(500);

            DealInitialCards(); // Deal initial cards to the player and dealer
            UpdateUI();
        }

        private void DealInitialCards()
        {
            // Deal two cards to player and dealer
            dealer.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());
            player.AddCard(deck.DealCard());
            UpdateUI();
            player.AddCard(deck.DealCard());

        }

        private void UpdateUI()
        {
            // Display player's cards and score         
            playerScoreLabel.Text = $"Score: {player.Score}";

            // Remove existing player's dynamically added PictureBoxes
            foreach (var control in this.Controls.OfType<PictureBox>().ToList())
            {
                if (control.Tag?.ToString() == "Player")
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Dynamically add PictureBox for player cards
            int xPosition = 40;
            int yPosition = 300;

            foreach (var card in player.Hand)
            {
                Image cardImage = cardImages.GetCardImage(card.FileName);
                if (cardImage == null)
                {
                    MessageBox.Show($"Image for {card.FileName} not found!");
                }

                PictureBox pictureBox = new PictureBox
                {
                    Image = cardImages.GetCardImage(card.FileName),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 150,
                    Location = new Point(xPosition, yPosition),
                    Tag = "Player"
                };
                this.Controls.Add(pictureBox);
                xPosition += 120; 
            }

            // Display dealer's cards
            

            foreach (var control in this.Controls.OfType<PictureBox>().ToList())
            {
                if (control.Tag?.ToString() == "Dealer")
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }
            xPosition = 40;
            yPosition = 70;

            // Dealer's first card should be face down initially
            var dealerFirstCard = dealer.Hand[0];
            PictureBox dealerPictureBox1 = new PictureBox
            {
                Image = cardImages.GetCardImage("blue"), 
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 100,
                Height = 150,
                Location = new Point(xPosition, yPosition),
                Tag = "DealerFirstCard"
            };
            this.Controls.Add(dealerPictureBox1);

            xPosition += 120;

            // Show the second card and onwards
            foreach (var card in dealer.Hand.Skip(1)) 
            {
                PictureBox dealerPictureBox = new PictureBox
                {
                    Image = cardImages.GetCardImage(card.FileName),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 150,
                    Location = new Point(xPosition, yPosition),
                    Tag = "Dealer"
                };
                this.Controls.Add(dealerPictureBox);
                xPosition += 110;
            }
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            if (player.IsBusted || player.IsStanding) return;

            // Deal a card to the player
            player.AddCard(deck.DealCard());
            UpdateUI();

            // Check if player has busted
            if (player.IsBusted)
            {
                MessageBox.Show("You busted! Dealer wins.");
                UpdateScoreAndUI(isWin: false);
                ResetGame();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            player.IsStanding = true;
            dealerPlay();
     
        }

        private async void dealerPlay()
        {
            while (dealer.Score < 17)
            {
                dealer.AddCard(deck.DealCard());
            }

            // update the dealer’s first 
            var dealerFirstCard = dealer.Hand[0]; //actual first card


            foreach (var control in this.Controls.OfType<PictureBox>().ToList())
            {
                if (control.Tag?.ToString() == "DealerFirstCard")
                {
                    control.Image = cardImages.GetCardImage(dealerFirstCard.FileName);
                    break; 
                }
            }
            UpdateUI();
            dealerScoreLabel.Text = $"Score: {dealer.Score}";

            // Check if the dealer busted or not
            string resultMessage = string.Empty;
            if (dealer.IsBusted)
            {
                resultMessage = "Dealer busted! You win.";
                UpdateScoreAndUI(isWin: true);
            }
            else if (dealer.Score > player.Score)
            {
                resultMessage = "Dealer wins.";
                UpdateScoreAndUI(isWin: false);
            }
            else if (dealer.Score < player.Score)
            {
                resultMessage = "You win!";
                UpdateScoreAndUI(isWin: true);
            }
            else
            {
                resultMessage = "It's a tie!";
            }

            MessageBox.Show(resultMessage);  
            ResetGame();
        }

        private void UpdateScoreAndUI(bool isWin)
        {
            if (isWin)
            {
                wins++; // Increment win count
                winLabel.Text = $"WINS: {wins}"; // Update win label
            }
            else
            {
                losses++; // Increment loss count
                lostLabel.Text = $"LOST: {losses}"; // Update loss label
            }
        }

        private void ResetGame()
        {
            DialogResult playAgain = MessageBox.Show("Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);

            if (playAgain == DialogResult.Yes)
            {
                // Reset hands and deck, then shuffle
                player.ResetHand();
                dealer.ResetHand();
                deck.ResetDeck();
                deck.Shuffle();

                // Clear previous images of cards
                foreach (var control in this.Controls.OfType<PictureBox>().ToList())
                {
                    if (control.Tag?.ToString() == "Player" || control.Tag?.ToString() == "Dealer" || control.Tag?.ToString() == "DealerFirstCard")
                    {
                        this.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                // Deal new cards and update the UI
                DealInitialCards();
                UpdateUI();
                HitButton.Enabled = true;
                StandButton.Enabled = true;
            }
            else
            {
                // Show the main menu and close the current game form
                Form1 mainMenuForm = new Form1();
                mainMenuForm.Show();
                this.Hide();
            }
        }

    }
}
