using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace UnusualPlantsOfTheWorld
{
    public partial class Form1 : Form
    {

        Words[] ListOfWords = new Words[]
            {
                new Words(7, 2, "batflower", 'r', 8),
                new Words(6, 18, "drosera", 'r', 6),
                new Words(10, 1, "wolffia", 'r', 6),
                new Words(10, 11, "clitoria", 'r', 7),
                new Words(12, 15, "breadfruit", 'r', 9),
                new Words(14, 3, "agave", 'r', 4),
                new Words(15, 17, "toxicodendron", 'r', 12),
                new Words(17, 5, "amorphophallus", 'r', 13),
                new Words(20, 0, "welwitschia", 'r', 10),
                new Words(22, 0, "curare", 'r', 5),
                new Words(24, 0, "cicuta", 'r', 5),
                new Words(6, 3, "rafflesia", 'd', 8),//
                new Words(13, 5, "baobab", 'd', 5),
                new Words(11, 9, "leontopodium", 'd', 11),
                new Words(0, 24, "wolfsbane", 'd', 8),
                new Words(4, 21, "passiflora", 'd', 9),
                new Words(8, 18, "phalaenopsis", 'd', 11),
                new Words(15, 12, "nepenthes", 'd', 8),
                new Words(17, 16, "lithops", 'd', 6),
                new Words(19, 1, "sequoia", 'd', 6),
                new Words(15, 23, "dictamnus", 'd', 8)
            };

        public Form1()
        {

            InitializeComponent();

            Field.ColumnCount = 30;
            Field.RowCount = 26;

            PaintCells(0, 24, 'd', 8);//
            PaintCells(4, 21, 'd', 9);//
            PaintCells(8, 18, 'd', 11);//
            PaintCells(6, 3, 'd', 8);//
            PaintCells(13, 5, 'd', 5);//
            PaintCells(11, 9, 'd', 11);//
            PaintCells(19, 1, 'd', 6);//
            PaintCells(15, 12, 'd', 8);//
            PaintCells(17, 16, 'd', 6);//
            PaintCells(15, 23, 'd', 8);//

            PaintCells(7, 2, 'r', 8);//
            PaintCells(10, 1, 'r', 6);//
            PaintCells(14, 3, 'r', 4);//
            PaintCells(17, 5, 'r', 13);//
            PaintCells(10, 11, 'r', 7);//
            PaintCells(6, 18, 'r', 6);//
            PaintCells(12, 15, 'r', 9);//
            PaintCells(15, 17, 'r', 12);//
            PaintCells(20, 0, 'r', 10);//
            PaintCells(22, 0, 'r', 5);//
            PaintCells(24, 0, 'r', 5);//

            PaintCell(15, 23);
            PaintCell(17, 16);


        }
        
        private void PaintCells(byte startI, byte startJ, char direction, byte count)
        {
            Field.Rows[startI].Cells[startJ].Style.BackColor = Color.FromArgb(255, 0, 94);

            if (direction == 'd')
            {
                for (var i = startI + 1; i <= startI + count; i++)
                    Field.Rows[i].Cells[startJ].Style.BackColor = Color.FromArgb(169, 255, 76);
            }
            else if (direction == 'r')
            {
                for (var j = startJ + 1; j <= startJ + count; j++)
                    Field.Rows[startI].Cells[j].Style.BackColor = Color.FromArgb(169, 255, 76);
            }
        }

        private void PrintWord(Words obj)
        {
            Field.Rows[obj.i].Cells[obj.j].Value = obj.CorrectVariant[0];

            if (obj.direction == 'd')
            {
                for (var i = obj.i; i <= obj.count + obj.i; i++)
                    Field.Rows[i].Cells[obj.j].Value = obj.CorrectVariant[i- obj.i];
            }
            else if (obj.direction == 'r')
            {
                for (var j = obj.j; j <= obj.count + obj.j; j++)
                    Field.Rows[obj.i].Cells[j].Value = obj.CorrectVariant[j - obj.j];
            }
        }

        private void PaintCell(byte i, byte j)
        {
            Field.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 94);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About form = new About();

            form.Show();

            form.BackColor = Color.AliceBlue;
        }

        uint CountOfTapField = 0; byte ActiveI, ActiveJ;
        private void Field_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CountOfTapField++;
            if (CountOfTapField == 1)
            {
                Greeting.Visible = false;
                Greeting1.Visible = false;
                Greeting2.Visible = false;
                BarForQuestion.Visible = true;
                PictureBox.Visible = true;
                EnterFiled.Visible = true;
                Enter.Visible = true;
            }

            if(CountOfTapField != 1) EnterFiled.Text = "";

            for (int k = 0; k < ListOfWords.Length; k++)
                for (int i = 0; i < Field.RowCount; i++)
                    for (int j = 0; j < Field.ColumnCount; j++)
                        if (ListOfWords[k].i == e.RowIndex && ListOfWords[k].j == e.ColumnIndex)
                        {
                            BarForQuestion.Clear();
                            BarForQuestion.Text = ListOfWords[k].QuestionForWord;
                            PictureBox.ImageLocation = ListOfWords[k].PictureForWord;
                            ActiveI = ListOfWords[k].i; ActiveJ = ListOfWords[k].j;
                        }

        }

        private  bool HaveFinished()
        {
            foreach (var item in ListOfWords)
                if (item.finish != true)
                    return false;

            return true;
        }

        private void EnterFiled_Enter(object sender, EventArgs e)
        {
            EnterFiled.Text = "";
        }

        private void EnterFiled_Leave(object sender, EventArgs e)
        {
            
        }

        
        private void Enter_Click(object sender, EventArgs e)
        {
            string entered = EnterFiled.Text;
    
            for (int k = 0; k < ListOfWords.Length; k++)
                for (int i = 0; i < Field.RowCount; i++)
                    for (int j = 0; j < Field.ColumnCount; j++)
                        if (ListOfWords[k].i == ActiveI && ListOfWords[k].j == ActiveJ)
                        {
                            
                            if (entered.ToLower() == ListOfWords[k].CorrectVariant)
                            {
                                PrintWord(ListOfWords[k]);
                                ListOfWords[k].finish = true;
                            }
                            else
                            {
                               MessageBox.Show("You have entered the wrong word. Try again!", "Error");
                               return;
                            }
                              
                        }
            if (HaveFinished() == true)
            {
                Congratulations fC = new Congratulations();
                fC.Show();
            }
            return;
        }
    }

    class Words
    {
        static byte NumOfObj = 0;
        public byte id;
        public byte i;
        public byte j;
        public byte count;
        public bool finish;
        public char direction;
        public string QuestionForWord;
        public string PictureForWord;
        public string CorrectVariant;
        public static string[] Question = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Questions.txt"));

        public Words(byte i, byte j, string word, char direction, byte count)
        {
            this.i = i;
            this.j = j;
            this.count = count;
            this.direction = direction;
            finish = false;
            CorrectVariant = word;
            NumOfObj++;
            id = NumOfObj;
            QuestionForWord = Question[id - 1];
            PictureForWord = Path.Combine(Environment.CurrentDirectory, "Pictures", (Convert.ToString(id) + ".jpg"));
 
        }

        

    }

}
