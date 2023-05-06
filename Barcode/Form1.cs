namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void deseneaza(Graphics g)
        {


            Point a = new Point(p.Size.Width / 4, p.Size.Height / 2 - 50);
            Point b = new Point(p.Size.Width / 4, p.Size.Height / 2 + 50);
            //Am setat coordonatele punctelor ce determina prima linie


            FileStream fs = null; StreamReader sr = null;
            fs = new FileStream("cod.txt", FileMode.Open);
            sr = new StreamReader(fs);
            string cod = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            //Am citit din fisier tabelul si l-am copiat in string-ul cod


            int[] lg = new int[50];
            lg['0'] = 3;
            lg['1'] = 5;
            //Am determinat lungimea liniilor

            Color c;
            int i, l = 0, nr = 1;
            int si = 0, sp = 0;
            int val, kk, key = 0;

            string v0 = valoare.Text; //valoarea intiala citita din textbox

            for (i = 0; i < v0.Length; i++)
            {
                val = Convert.ToInt32(v0[i]) - 48;
                if (i % 2 == 0)
                    si = si + val;
                else sp = sp + val;

            }
            kk = si + sp * 3;
            while (kk % 10 != 0)
            {
                key++;
                kk++;
            }
            string v = ("0" + v0 + key);
            val_fin.Text = v;
            val_fin.Visible = false;
            //Calculam valoarea finala

            if (v.Length % 2 == 0)
            {
                for (i = 0; i < v.Length; i++)
                {
                    int ok = 0;
                    for (int j = 0; j < 60; j = j + 6)
                    {

                        if (v[i].CompareTo(cod[j]) == 0)
                        {

                            a.Offset((l + lg[cod[j + 1]]) / 2, 0);
                            b.Offset((l + lg[cod[j + 1]]) / 2, 0);


                            ok = 1;
                            for (int k = j + 1; k < j + 6; k++)
                            {

                                if (checkBox2.Checked == false)
                                {
                                    if (nr % 2 == 1)
                                        c = Color.Black;
                                    else c = Color.White;


                                }
                                else
                                {
                                    if (nr % 2 == 0)
                                        c = Color.Black;
                                    else c = Color.White;

                                }

                                nr++;
                                g.DrawLine(new Pen(c, lg[cod[k]]), a, b);


                                if (k < j + 5)
                                {
                                    a.Offset((lg[cod[k]] + lg[cod[k + 1]]) / 2, 0);
                                    b.Offset((lg[cod[k]] + lg[cod[k + 1]]) / 2, 0);

                                }
                                l = lg[cod[j + 5]];

                            }

                        }
                        if (ok == 1) break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Valorile acceptate trebuie să aibă un număr par de cifre!");
                val_fin.Text = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                p.BackColor = Color.Black;
            else p.BackColor = Color.White;

            if (checkBox1.Checked == true)
                deseneaza(p.CreateGraphics());
            else p.CreateGraphics().Clear(p.BackColor);

            if (checkBox3.Checked == true)
                val_fin.Visible = true;

        }

    }
}
