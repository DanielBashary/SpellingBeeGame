using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingBeeGame
{
    public partial class SpellingBeeGame : Form
    {
        List<char> wordList = SpellingBeeModel.WordList(7);
        private String wordEntered = "";
        private int score = 0;

        public SpellingBeeGame()
        {
            InitializeComponent2();
        }

        private void InitializeComponent2()
        {
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.label1 = new Label();
            this.button9 = new Button();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.button8 = new Button();
            this.button10 = new Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(279, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = wordList[0].ToString();
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(437, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = wordList[1].ToString();
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(437, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 93);
            this.button3.TabIndex = 2;
            this.button3.Text = wordList[2].ToString();
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(279, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 83);
            this.button4.TabIndex = 3;
            this.button4.Text = wordList[3].ToString();
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(114, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 93);
            this.button5.TabIndex = 4;
            this.button5.Text = wordList[4].ToString();
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(114, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 95);
            this.button6.TabIndex = 5;
            this.button6.Text = wordList[5].ToString();
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(279, 207);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 93);
            this.button7.TabIndex = 6;
            this.button7.Text = wordList[6].ToString();
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(492, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score: ";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button9.Location = new System.Drawing.Point(279, 398);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(161, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "Submit";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(551, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(138, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(32, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Word Entered:";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(454, 402);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(176, 35);
            this.button8.TabIndex = 13;
            this.button8.Text = "RESET GAME";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(79, 402);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(164, 35);
            this.button10.TabIndex = 14;
            this.button10.Text = "Reset Word";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // SpellingBeeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button10);
            this.Name = "SpellingBeeGame";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.button9_Click);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordEntered += wordList[0];
            label3.Text = wordEntered;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wordEntered += wordList[1];
            label3.Text = wordEntered;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            wordEntered = wordEntered + wordList[2];
            label3.Text = wordEntered;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            wordEntered = wordEntered + wordList[3];
            label3.Text = wordEntered;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            wordEntered = wordEntered + wordList[4];
            label3.Text = wordEntered;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wordEntered += wordList[5];
            label3.Text = wordEntered;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            wordEntered = wordEntered + wordList[6];
            label3.Text = wordEntered;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int scoreAdd = SpellingBeeModel.WordChecker(wordList, wordEntered);
            score += scoreAdd;
            label2.Text = score.ToString();
            label3.Text = "ENTER A WORD";
            wordEntered = "";
        }

        private void button8_Click(object sender, EventArgs e)
        { 
            wordList = SpellingBeeModel.WordList(7);
            String wordEntered = "";
            score = 0;
            button1.Text = wordList[0].ToString();
            button2.Text = wordList[1].ToString();
            button3.Text = wordList[2].ToString();
            button4.Text = wordList[3].ToString();
            button5.Text = wordList[4].ToString();
            button6.Text = wordList[5].ToString();
            button7.Text = wordList[6].ToString();
            label3.Text = wordEntered;
            label2.Text = score.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wordEntered = "";
            label3.Text = wordEntered;
        }
    }
}
