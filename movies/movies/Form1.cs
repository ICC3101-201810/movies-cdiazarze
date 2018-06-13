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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panels.Add("Search", panelSearch);
            foreach (String s in panels.Keys)
                if (!s.Equals("Search"))
                    panels[s].Visible = false;
            DataArgs.panels = panels;
        }

        //Eventos
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

        //Metodos

        public void UpdateSearch(List<String> list)
        {
            CleanSearch();
            int counter = 0;
            if (list.Count > 0)
            {
                foreach (String element in list)
                {
                    if (counter <= 50)
                    {
                        if (listResultado.Items.Count > 0 && listResultado.Items[0].Equals("No existen resultados para el criterio de busqueda"))
                        {
                            listResultado.Items.Add(element);
                            listResultado.Items.RemoveAt(0);
                        }
                        else
                            listResultado.Items.Add(element);
                        counter++;
                    }
                }
            }
            else NoResult();
        }
        public void NoResult()
        {
            listResultado.Items.Add("No existen resultados para el criterio de busqueda");
        }
        public void CleanSearch()
        {
            listResultado.Items.Clear();
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
