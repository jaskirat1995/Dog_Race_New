using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race_New
{
    public partial class Form1 : Form
    {
        //instance of the abstract class that is used to to generate the no of position to move the dog from one position to another 
        play instance = new play();

        dog1 inst_dog1 = new dog1();
        dog2 inst_dog2 = new dog2();
        dog3 inst_dog3 = new dog3();
        dog4 inst_dog4 = new dog4();


        //global declaration area that is used to handle the whole with the aspect to find the winner of the game and name or amount 
        int winner = 0, Frstplyr = 50, ScndPlyr = 50, ThrdPlyr = 50;
        int FrstDog = 0, ScndDog = 0, ThrdDog = 0,frthDog=0;
        int Amount1 = 0, Amount2 = 0, Amount3 = 0;

        public Form1()
        {
            InitializeComponent();
            //calling the starting message of the game that is used to print the term and condition of the game 
            MessageBox.Show("Wel come to the Dog Race "+"\n "+ "Bet Amount is starting from Minimum 1 Dollar ");
        }
        // this is also post define method that is used to get  the reset position of the dog that is  move the dog to the starting position 
        public void resetGame() {
            Dog1.Left = instance.resetTheDog();
            Dog2.Left = instance.resetTheDog();
            Dog3.Left = instance.resetTheDog();
            Dog4.Left = instance.resetTheDog();
            //reset the position and name of the player and reset the variable of all the variable of the game 

            Player1.Text = "Player1";
            Player2.Text = "Player2";
            Player3.Text = "Player3";

            FrstDog = 0;
            ScndDog = 0;
            ThrdDog = 0;

            Amount1 = 0;
            Amount2 = 0;
            Amount3 = 0;

            
        }

        private void RBOption1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int start = 2, end = 20;
            Dog4.Left = Dog4.Left + inst_dog4.run(start, end);
            if (Dog4.Left > 830)
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer1.Enabled = false;
                timer4.Enabled = false;
                winner = inst_dog4.winner(Dog4.Left);
                winner = 4;
                MessageBox.Show("Dog 4 is the Winner");
                Srchwinner();
                resetGame();
            }


        }

        // this is also user define method that is used to find the winner of the game with relevant name of the player and winning amount of the bet 
        // to increment or decrement the amount of the winner player  we have used the concept of the ladder if-condition to find the winner or looser of the game 
        public void Srchwinner()
        {
            if (FrstDog>0 && FrstDog==winner)
            {
                Frstplyr = Frstplyr + Amount1;
                RBOption1.Text = "Harjot has " + Frstplyr + " Dollar ";
                MessageBox.Show("Congress Harjot you are the winner");
            }
            else if(FrstDog > 0 && FrstDog != winner)
            {
                Frstplyr = Frstplyr - Amount1;
                RBOption1.Text = "Harjot has " + Frstplyr + " Dollar";
                MessageBox.Show("Harjot you are not  the winner");

            }

            if (ScndDog > 0 && ScndDog == winner)
            {
                ScndPlyr = ScndPlyr+ Amount2;
                RBOption2.Text = "Manjot has " + ScndPlyr + " Dollar";
                MessageBox.Show("Congress Manjot you are the winner");
            }
            else if (ScndDog> 0 && ScndDog != winner)
            {
                ScndPlyr = ScndPlyr - Amount2;
                RBOption2.Text = "Harjot has " + ScndPlyr + " Dollar";
                MessageBox.Show("Manjot you are not  the winner");

            }

            if (ThrdDog > 0 && ThrdDog == winner)
            {
                ThrdPlyr=ThrdPlyr + Amount3;
                RBOption3.Text = "David has " + ThrdPlyr + "  Dollar";
                MessageBox.Show("Congress David you are the winner");
            }
            else if (ThrdDog > 0 && ThrdDog != winner)
            {
                ThrdPlyr = ThrdPlyr - Amount3;
                RBOption3.Text = "David has " + ThrdPlyr + "  Dollar";
                MessageBox.Show("David you are not  the winner");
            }





        }

        private void SetBet_Click(object sender, EventArgs e)
        {
            // this if-condition is used to set the bet amount of the player and also store the dog which is chooosed by the player 
            if (RBOption1.Checked && Dog.Value > 0 && Dog.Value <= 4 && Amount.Value<=Frstplyr && Amount.Value>0)
            {

                Player1.Text = "Harjot set $" + Amount.Value + " on Dog " + Dog.Value + " for Race";
                
                FrstDog = Convert.ToInt32(Dog.Value);
                Amount1 = Convert.ToInt32(Amount.Value);
                btnRun.Visible = true;

            }
           
           else  if (RBOption2.Checked && Dog.Value > 0 && Dog.Value <= 4 && Amount.Value <= ScndPlyr && Amount.Value > 0)
            {
                Player2.Text = "Manjot set $" + Amount.Value + " on Dog " + Dog.Value + " for Race";
                ScndDog = Convert.ToInt32(Dog.Value);
                Amount2 = Convert.ToInt32(Amount.Value);
                btnRun.Visible = true;
            }
           
            else if (RBOption3.Checked && Dog.Value > 0 && Dog.Value <= 4 && Amount.Value <= ThrdPlyr && Amount.Value > 0)
            {
                Player3.Text = "David set $" + Amount.Value + " on Dog " + Dog.Value + " for Race";

                    ThrdDog = Convert.ToInt32(Dog.Value);
                    Amount3 = Convert.ToInt32(Amount.Value);
                    btnRun.Visible = true;
            }
            else
            {
                MessageBox.Show("Choose the Dog for the bet and \n also check your amount and bet amount");
            }

        }

       
        //enable the timer for the dog to run 
        public void run() {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        // these timer method that are used to move the dog to run in the game from one place to another  and display the winner by choosing the player by calling the method 
        private void timer1_Tick(object sender, EventArgs e)
        {
            int start = 2, end = 18;

            Dog1.Left = Dog1.Left + inst_dog1.run(start,end) ;

            if (Dog1.Left > 830) {
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer1.Enabled = false;
                timer4.Enabled = false;
                winner = inst_dog1.winner(Dog1.Left);
                winner = 1;

                MessageBox.Show("Dog 1 is the Winner");
                Srchwinner();
                resetGame();
            }




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int start = 2, end = 15;

            
            Dog2.Left = Dog2.Left + inst_dog2.run(start, end);
            if (Dog2.Left > 830)
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer1.Enabled = false;
                timer4.Enabled = false;
                winner = inst_dog2.winner(Dog2.Left);    
                winner = 2;

                MessageBox.Show("Dog 2 is the Winner");
                Srchwinner();
                resetGame();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int start = 2, end = 13;
            Dog3.Left = Dog3.Left + inst_dog3.run(start, end);
            if (Dog3.Left > 830)
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer1.Enabled = false;
                timer4.Enabled = false;
                winner = inst_dog3.winner(Dog3.Left);
                winner = 3;
                MessageBox.Show("Dog 3 is the Winner");
                Srchwinner();
                resetGame();
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // this is the button that is used to start the game after cicking on the start game i sound of fire will generate to trigger the game 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("fire.wav");
            player.Play();

            //calling the method of the dog race to run the dog
            run();
        }
    }
}
