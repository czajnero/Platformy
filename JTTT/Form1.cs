using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT
{
    public partial class Form1 : Form
    {
        Log jtttLog = new Log();
        BindingList<JTTTRecipe> listOFTasks;
        JtttSerialization serializer;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWykonaj_Click(object sender, EventArgs e)
        {
            jtttLog.log("Wcisnieto przycisk startu.");

            foreach (JTTTRecipe item in tasksListBox.Items)
            {
                item.RunActions();
            }

        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            jtttLog.log("Wcisnieto przycisk dodania do listy.");
            try
            {
                JTTTQuestion jTTTQuestion;

                if (tabQuestion.SelectedTab.Text == tabFindText.Text)
                {
                    jTTTQuestion = new FindText(textBoxURL.Text, textBoxTekst.Text, textBoxEmail.Text);
                }
                else
                {
                    jTTTQuestion = new TempCheck(textBoxMiasto.Text, double.Parse(comboBoxTemp.Text));
                }

                JTTTAction jTTTAction;

                if (tabControlAction.SelectedTab.Text == tabPageEmail.Text)
                {
                    jTTTAction = new SendMail(textBoxEmail.Text);
                }
                else
                {
                    jTTTAction = new ShowResult();
                }

                JTTTRecipe jTTTRecipe = new JTTTRecipe(jTTTAction, jTTTQuestion);
                listOFTasks.Add(jTTTRecipe);

                using (var tmp = new JTTTDBContext())
                {
                    tmp.JTTTRecipes.Add(jTTTRecipe);
                    tmp.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
   

        private void MainForm_Load(object sender, EventArgs e)
        {
            serializer = new JtttSerialization();
            listOFTasks = new BindingList<JTTTRecipe>();
            tasksListBox.DataSource = listOFTasks;
            using (var tmp = new JTTTDBContext())
            {
                var list = tmp.JTTTRecipes.Include("Action").Include("Question");
                    foreach (var a in list)
                        {
                             listOFTasks.Add(a);
                        }
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            jtttLog.log("Wcisnieto przycisk czyszczenia.");
            listOFTasks.Clear();

        }

        private void DeserialButton_Click(object sender, EventArgs e)
        {
            jtttLog.log("Wcisnieto przycisk deserializacji.");

            using (var tmp = new JTTTDBContext())
            {
                foreach (var item in listOFTasks)
                {
                    JTTTAction action = tmp.JTTTActions.Find(item.Id);
                    if (action != null)
                    {
                        tmp.JTTTActions.Remove(action);
                    }
                }
                
                listOFTasks = (BindingList<JTTTRecipe>)serializer.Deserialize("JTTTser.dat");

                foreach (var item in listOFTasks)
                {
                    tmp.JTTTRecipes.Add(item);
                    jtttLog.log(string.Format("Dodano zdarzenie: {0}.", item));
                }
                tmp.SaveChanges();
                tasksListBox.DataSource = listOFTasks;
            }
        }
        private void SerialButton_Click(object sender, EventArgs e)
        {
            jtttLog.log("Wcisnieto przycisk serializacji.");
            serializer.Serialize(listOFTasks, "JTTTser.dat");
        }

        private void buttonDeleteFromDatabase_Click(object sender, EventArgs e)
        {
            jtttLog.log("Wcisnieto przycisk usuniecia zadania z bazy");
            using (var tmp = new JTTTDBContext())
            {
                foreach (JTTTRecipe item in tasksListBox.SelectedItems)
                {
                    JTTTRecipe recipe = tmp.JTTTRecipes.Find(item.Id);
                    if (recipe != null)
                    {
                        tmp.JTTTRecipes.Remove(recipe);
                    }
                }
                tmp.SaveChanges();

                listOFTasks.Clear();
                foreach (var item in tmp.JTTTRecipes.Include("Question").Include("Action"))
                {
                    listOFTasks.Add(item);
                }
            }
        }









        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
