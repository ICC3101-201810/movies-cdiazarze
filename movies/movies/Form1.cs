using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movies
{
    public partial class Form1 : Form
    {
        DataEventArgs DataArgs = new DataEventArgs();
        Dictionary<String, Panel> panels = new Dictionary<String, Panel>();

        public event EventHandler<DataEventArgs> OnSearch;
        public event EventHandler<DataEventArgs> OnClosingApp;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panels.Add("Inicio", panelInicio);
            
            foreach (String s in panels.Keys)
                if (!s.Equals("Inicio"))
                    panels[s].Visible = false;
            DataArgs.panels = panels;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length >= 3) { 
                if (OnSearch != null)
                {
                    DataArgs.searchWord = searchBox.Text;
                    OnSearch(this, DataArgs);
                }
            }
        }

        //Metodos para confirmar cierre
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            close_Click();
            CloseCancel(e);
        }
        private void close_Click()
        {
            OnClosingApp(this, DataArgs);
        }

        private void CloseCancel(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
    }
}
