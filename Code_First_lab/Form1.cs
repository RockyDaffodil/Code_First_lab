using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_lab
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        string conn_str = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        OlympicContext db = null;
        string Picture;
        public Form1()
        {
            InitializeComponent();
            button8.Click += button8_Click;

            hide_all();
            try
            {
                db = new OlympicContext();
                //db.Country.Add(new Country() { NameCountry = "Ukraine" });
                //db.SaveChanges();
            }
            catch (Exception)
            {

            }
        }
        public void hide_all()
        {
            try
            {
                comboBox2.DataSource = db.Country.Select(m => m.NameCountry).ToList();
                comboBox3.DataSource = db.Conducting.Select(m => m.ConductingOlympicName).ToList();
                comboBox4.DataSource = db.Country.Select(m => m.NameCountry).ToList();
                comboBox5.DataSource = db.Country.Select(m => m.NameCountry).ToList();
                comboBox6.DataSource = db.Participants.Select(m => m.FullName).ToList();
                comboBox7.DataSource = db.NameOfsSports.Select(m => m.NameSport).ToList();
                comboBox8.DataSource = db.Participants.Select(m => m.FullName).ToList();
                comboBox9.DataSource = db.Summer_Winter_Olymp.Select(m => m.NameWinter).ToArray();
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            comboBox2.Visible = false;
            //needing to add combobox names of the items
            button2.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            comboBox8.Visible = false;
            comboBox3.Visible = false;
            button3.Visible = false;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox5.Visible = false;
            comboBox4.Visible = false;
            comboBox9.Visible = false;
            textBox8.Visible = false;
            comboBox7.Visible = false;
            button4.Visible = false;

            label11.Visible = false;
            textBox10.Visible = false;
            button5.Visible = false;

            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            button6.Visible = false;

            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            textBox14.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            textBox17.Visible = false;
            button8.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var list = from a in db.City
                           join b in db.Country on a.CountryId equals b.Id
                           select new { City = a.NameCity, Country = b.NameCountry };
                //var dbset = db.City.Select(m => new { m.NameCity, m.CountryId }).ToList();
                //dataGridView1.DataSource = dbset.ToList();
                dataGridView1.DataSource = list.ToList();

                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                comboBox2.Visible = true;
                //needing to add combobox names of the items
                button2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var list = from a in db.conductingParticipants
                           join b in db.Participants on a.ParticipantsId equals b.Id
                           join c in db.Conducting on a.ConductingId equals c.Id
                           select new { Participant = b.FullName, Olympic = c.ConductingOlympicName };
                //var dbset = db.conductingParticipants.Select(m => new { m.ParticipantsId, m.ConductingId }).ToList();
                //dataGridView1.DataSource = dbset.ToList();
                dataGridView1.DataSource = list.ToList();

                label4.Visible = true;
                label5.Visible = true;
                comboBox8.Visible = true;
                comboBox3.Visible = true;
                button3.Visible = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var list = from a in db.Conducting
                           join b in db.Country on a.CountryId equals b.Id
                           join c in db.Summer_Winter_Olymp on a.Summer_Winter_OlympId equals c.Id
                           join d in db.NameOfsSports on a.SportId equals d.Id
                           select new { Olympic = a.ConductingOlympicName, Country = b.NameCountry, Weather = c.NameWinter, Sport = d.NameSport };
                //var dbset = db.Conducting.Select(m => new { m.ConductingOlympicName, m.CountryId, m.Summer_Winter_OlympId, m.DateStart, m.SportId, m.NameOfsSports }).ToList();
                //dataGridView1.DataSource = dbset.ToList();
                dataGridView1.DataSource = list.ToList();

                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox5.Visible = true;
                comboBox4.Visible = true;
                comboBox9.Visible = true;
                textBox8.Visible = true;
                comboBox7.Visible = true;
                button4.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                //var list = from a in db.Conducting
                //           join b in db.Country on a.CountryId equals b.Id
                //           join c in db.Summer_Winter_Olymp on a.Summer_Winter_OlympId equals c.Id
                //           join d in db.NameOfsSports on a.SportId equals d.Id
                //           select new { Olympic = a.ConductingOlympicName, Country = b.NameCountry, Weather = c.NameWinter, Sport = d.NameSport };
                var dbset = db.Country.Select(m => new { m.NameCountry }).ToList();
                dataGridView1.DataSource = dbset.ToList();

                label11.Visible = true;
                textBox10.Visible = true;
                button5.Visible = true;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                var dbset = db.NameOfsSports.Select(m => new { m.NameSport, m.Sport_Information, m.MaxParticipants }).ToList();
                dataGridView1.DataSource = dbset.ToList();

                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                button6.Visible = true;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                var list = from a in db.Participants
                           join b in db.Country on a.CountryId equals b.Id
                           join c in db.NameOfsSports on a.SportId equals c.Id
                           select new { FullName = a.FullName, Country = b.NameCountry, Sport = c.NameSport, Birth = a.DateOfBirth, Picture = a.Participant_Picture };
                //var dbset = db.Participants.Select(m => new { m.FullName, m.CountryId, m.SportId, m.DateOfBirth, m.Participant_Picture }).ToList();
                //dataGridView1.DataSource = dbset.ToList();
                dataGridView1.DataSource = list.ToList();

                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                textBox14.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                textBox17.Visible = true;
                button8.Visible = true;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                var dbset = db.Summer_Winter_Olymp.Select(m => new { m.NameWinter }).ToList();
                dataGridView1.DataSource = dbset.ToList();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphics File|*.bmp; *.gif; *.jpg; *.png";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Picture = ofd.FileName;
                db.Participants.Add(new Participants { FullName = textBox14.Text, CountryId = db.Country.Where(m => m.NameCountry == comboBox5.SelectedItem.ToString()).Select(w => w.Id).First(), SportId = db.NameOfsSports.Where(m => m.NameSport == comboBox6.SelectedItem.ToString()).Select(w => w.Id).First(), DateOfBirth = textBox17.Text, Participant_Picture = CreateCopy() });
                db.SaveChanges();
                button8.Click += button1_Click;
            }
        }
        private byte[] CreateCopy()
        {
            Image img = Image.FromFile(Picture);
            int maxWidth = 300, maxHeight = 300;
            //we pick the width
            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight);
            //the Picture is in the memory
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();
            //поток для ввода|вывода байт из памяти
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();//выносим в поток все данные
                       //из буфера
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.City.Add(new City() { NameCity = textBox1.Text, CountryId = db.Country.Where(m => m.NameCountry == comboBox2.SelectedItem.ToString()).Select(w => w.Id).First() /*int.Parse(comboBox2.SelectedItem.ToString())*/ });
            db.SaveChanges();
            button2.Click += button1_Click;
            hide_all();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.conductingParticipants.Add(new ConductingParticipants() { ConductingId = db.Conducting.Where(m => m.ConductingOlympicName == comboBox3.SelectedItem.ToString()).Select(w => w.Id).First(), ParticipantsId = db.Participants.Where(m => m.FullName == comboBox8.SelectedItem.ToString()).Select(w => w.Id).First() });
            db.SaveChanges();
            button3.Click += button1_Click;
            hide_all();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Conducting.Add(new Conducting() { ConductingOlympicName = textBox5.Text, CountryId = db.Country.Where(m => m.NameCountry == comboBox4.SelectedItem.ToString()).Select(w => w.Id).First(), Summer_Winter_OlympId = db.Summer_Winter_Olymp.Where(m => m.NameWinter == comboBox9.SelectedItem.ToString()).Select(w => w.Id).First(), DateStart = textBox8.Text, SportId = db.NameOfsSports.Where(m => m.NameSport == comboBox2.SelectedItem.ToString()).Select(w => w.Id).First() });
            db.SaveChanges();
            button4.Click += button1_Click;
            hide_all();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.Country.Add(new Country() { NameCountry = textBox10.Text });
            db.SaveChanges();
            button5.Click += button1_Click;
            hide_all();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db.NameOfsSports.Add(new NameOfsSports() { NameSport = textBox11.Text, Sport_Information = textBox12.Text, MaxParticipants = int.Parse(textBox13.Text) });
            db.SaveChanges();
            button6.Click += button1_Click;
            hide_all();
        }
    }
}