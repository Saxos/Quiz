using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Quiz
{
    public partial class Form1 : Form
    {

        OleDbConnection connect = null;
        OleDbDataAdapter adapterFrage = null;
        DataSet dsFrage = null;
        FragenSammlung fs = new FragenSammlung();
        Thread t;
        Frage f;
        public Form1()
        {
            InitializeComponent();
            init();
            ThreadStart ts = fillProgress;
        //    t = new Thread(ts);
            clearFelder();
            pktTextBox.Text = 0;
           
        }

        private void init()
        {
            readQuestion();
        }
        public void fillProgress()
        {
            while(progressBar1.Value < 100)
            { 
            Thread.Sleep(100);
            hochDamit();
            }
        }
        public void hochDamit()
        {
            progressBar1.PerformStep();
        }
        private void readQuestion()
        {
            connect = new OleDbConnection(Properties.Settings.Default.conString);
            adapterFrage = new OleDbDataAdapter("Select * from tFrage", connect);
            dsFrage = new DataSet();
            adapterFrage.Fill(dsFrage, "Frage");

            using (DataTableReader reader = dsFrage.Tables["Frage"].CreateDataReader())
                while (reader.Read())
                {
                    int i = 0;
                    Frage f = new Frage(reader.GetInt32(i++), reader.GetString(i++), reader.GetString(i++), reader.GetString(i++), reader.GetString(i++), reader.GetString(i++), reader.GetInt32(i++));
                    fs.AddFrage(f);
                }
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            FillFrage();
            progressBar1.PerformStep();
            t.Start();
        }

        private void FillFrage()
        {
            checkSelected();
            clearFelder();
            f = fs.RandomFrage();


                questionTextField.Text = f.FrageString;
                q1RadioButton.Text = f.getFrage(0);
                q2RadioButton.Text = f.getFrage(1);
                q3RadioButton.Text = f.getFrage(2);
                q4RadioButton.Text = f.getFrage(3);
                
            

            
        }

        private void checkSelected()
        {
            if(!questionTextField.Text.Equals(""))
            {
                if (q1RadioButton.Checked) 
                    checkAntwort(q1RadioButton.Text);
                else if(q2RadioButton.Checked)
                    checkAntwort(q2RadioButton.Text);
                else if(q3RadioButton.Checked)
                    checkAntwort(q3RadioButton.Text);
                else if(q4RadioButton.Checked)
                    checkAntwort(q4RadioButton.Text);
            }
        }

        private void checkAntwort(string p)
        {
            if(f.RichtigeFrage.Equals(p))
            {
                pktTextBox.Text = (Double.Parse(pktTextBox.Text) + 1).ToString();
            }
        }

        private void clearFelder()
        {
            questionTextField.Text = "";
            q1RadioButton.Text = "";
            q2RadioButton.Text = "";
            q3RadioButton.Text = "";
            q4RadioButton.Text = "";
        }

        private int getRandomRB()
        {
            Random r = new Random();
            int i = r.Next(0, 4) + 1;
            return i;
        }

    }
}
