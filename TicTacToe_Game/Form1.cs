using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2; // even= X turn; odd = O turn;
        public int turns = 0; // counting turns;
        //counting wins for both players and draws;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0; 
        string title = "Winner Result"; 
        

        System.Media.SoundPlayer sound1 = new System.Media.SoundPlayer(@"C:\Users\Abrar Tayyab\Documents\Visual Studio 2013\Projects\TicTacToe_Game\wavfile1.wav");
        System.Media.SoundPlayer sound2 = new System.Media.SoundPlayer(@"C:\Users\Abrar Tayyab\Documents\Visual Studio 2013\Projects\TicTacToe_Game\wavfile2.wav");                   
        

        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
            label2.Text = "PLAY NOW";

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

                if(player%2==0)
                {
                    button.Text = "X";
                    button.ForeColor = Color.SlateGray;
                    sound1.Play();
                    label2.Text = "O Turn Now";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    button.ForeColor = Color.SeaGreen;
                    sound1.Play();
                    label2.Text = "X Turn Now";
                    player++;
                    turns++;
                }
                if(CheckDraw()==true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    AfterWinGame();
                }
                if(CheckWinner() == true)
                {

                    if(button.Text=="X")
                    {
                        MessageBox.Show("X Won!", title);
                        s1++;
                        AfterWinGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!",title);
                        s2++;
                        AfterWinGame();
                    }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound2.Play();
            this.Close();
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
            label2.Text = "PLAY NOW";
        }
        void AfterWinGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void NGB_Click(object sender, EventArgs e)
        {
            label2.Text = "PLAY NOW";
            sound2.Play(); 
            NewGame();
        }

        bool CheckDraw()
        {
            if ((turns == 9)&&CheckWinner()==false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //horizontals checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            //vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            //diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            label2.Text = "PLAY NOW";
            sound2.Play();
            NewGame();
        }

        private void OWin_Click(object sender, EventArgs e)
        {

        }

        private void Draws_Click(object sender, EventArgs e)
        {

        }

        private void XWin_Click(object sender, EventArgs e)
        {

        }

    }
}
