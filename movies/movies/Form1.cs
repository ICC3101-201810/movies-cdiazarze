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
        public event EventHandler<DataEventArgs> OnButtonHit;
        public event EventHandler<DataEventArgs> OnClosingApp;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panels.Add("Search", panelSearch);
            panels.Add("AfterButton", panelAfterButton);
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

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            DataArgs.button = "Peliculas";
            if (OnButtonHit != null)
            {
                OnButtonHit(this, DataArgs);
            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            DataArgs.button = "Actores";
            if (OnButtonHit != null)
            {
                OnButtonHit(this, DataArgs);
            }
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            DataArgs.button = "Directores";
            if (OnButtonHit != null)
            {
                OnButtonHit(this, DataArgs);
            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            DataArgs.button = "Productores";
            if (OnButtonHit != null)
            {
                OnButtonHit(this, DataArgs);
            }
        }

        private void buttonEstudio_Click(object sender, EventArgs e)
        {
            DataArgs.button = "Estudios";
            if (OnButtonHit != null)
            {
                OnButtonHit(this, DataArgs);
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

        //Se utiliza metodo generico para todos las listas apretadas por los botones
        public void UpdateListAfterButton<T>(List<T> list)
        {
            CleanListAfterButton();
            labelList.Text=DataArgs.button;
            if (list.Count > 0)
            {
                foreach (T element in list)
                {
                    if (listAfterButton.Items.Count > 0 && listAfterButton.Items[0].Equals("No existen resultados para el criterio de busqueda"))
                    {
                        listAfterButton.Items.Add(element);
                        listAfterButton.Items.RemoveAt(0);
                    }
                    else
                        listAfterButton.Items.Add(element);
                }
            }
            else NoResultListAfterButton();
        }
        public void NoResultListAfterButton()
        {
            listResultado.Items.Add("No existen registros");
        }
        public void CleanListAfterButton()
        {
            listAfterButton.Items.Clear();
        }
        public void ShowPanelAfterButton()
        {
            panelAfterButton.Visible = true;
            panelSearch.Visible = false;
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

        private void buttonBackSearch_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
            CleanSearch();
            panelSearch.Visible = true;
            panelAfterButton.Visible = false;
            CleanListAfterButton();

        }
    }
}
