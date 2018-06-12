using Modelos;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace movies
{
    class Controller
    {
        List<Persona> personas;
        List<Estudio> estudios;
        List<Pelicula> peliculas;
        List<PeliculaActor> peliculaActores;
        List<PeliculaProductor> peliculaProductores;
        Form1 View;
        public Controller(Form1 views)
        {
            personas = new List<Persona>();
            estudios = new List<Estudio>();
            peliculas = new List<Pelicula>();
            peliculaActores = new List<PeliculaActor>();
            peliculaProductores = new List<PeliculaProductor>();
            View = views;

            View.OnClosingApp += SaveDataBeforeClosing_OnClosingApp;

            if (!LoadData())
            {
                InicializaUsuariosIniciales();
            }



        }

        //Grabar los datos antes de cerrar4447
        private void SaveDataBeforeClosing_OnClosingApp(object sender, DataEventArgs e)
        {
            SaveData(personas, estudios,peliculas,peliculaActores, peliculaProductores);
        }

        //Metodos de incializacion y serialize
        public void InicializaUsuariosIniciales()
        {
            personas.Add(new Persona("Brad", "Pitt", new DateTime(1968, 2, 5), "Actor americano, rubio y simpatico", "actor"));
            personas.Add(new Persona("Andres", "Perez", new DateTime(1964, 2, 5), "Actor asiatico, coloro y  no simpatico", "actor"));
            personas.Add(new Persona("Billy", "Cea", new DateTime(1992, 2, 5), "Actor chileno, estudiante y filantropo", "actor"));
            personas.Add(new Persona("Andres", "Howard", new DateTime(1970, 2, 5), "Director, estudiante, filantropo, padre de familia...", "director"));
            personas.Add(new Persona("James", "Howardo", new DateTime(1972, 2, 5), "Erase una vez un director...", "director"));
            personas.Add(new Persona("Billy", "Pitts", new DateTime(1980, 2, 5), "Director con frase tipica: Una vez vi un joven coloro", "director"));
            personas.Add(new Persona("John", "Cena", new DateTime(1965, 2, 5), "Productor..Se me acaban las ideas de descripcion...", "productor"));
            personas.Add(new Persona("Carlos", "Gonzalez", new DateTime(1970, 2, 5), "Poductor ingles, mundialmente conocido", "productor"));
            personas.Add(new Persona("Kim", "Perez", new DateTime(1978, 2, 5), "Poductor chileno de origen asiatico", "productor"));
            estudios.Add(new Estudio("Kim Estudios", "Avenida Gonzalez", new DateTime(1981, 2, 5)));
            estudios.Add(new Estudio("Pitts Howard", "Avenida Cea Howardo", new DateTime(1975, 2, 5)));
            estudios.Add(new Estudio("John Cena", "Brad Pitt", new DateTime(1982, 2, 5)));
            peliculas.Add(new Pelicula("Volando con Brad", personas[3], new DateTime(2018, 2, 5), "Una tarde volando con James", 1000000,estudios[0]));
            peliculas.Add(new Pelicula("Volando con Brad", personas[4], new DateTime(2017, 2, 5), "Una tarde volando con James", 1000000, estudios[1]));
            peliculas.Add(new Pelicula("Volando con Brad", personas[5], new DateTime(2018, 3, 5), "Una tarde volando con James", 1000000, estudios[2]));
            peliculaActores.Add(new PeliculaActor(peliculas[0], personas[0]));
            peliculaActores.Add(new PeliculaActor(peliculas[1], personas[1]));
            peliculaActores.Add(new PeliculaActor(peliculas[2], personas[2]));
            peliculaActores.Add(new PeliculaActor(peliculas[0], personas[2]));
            peliculaActores.Add(new PeliculaActor(peliculas[1], personas[0]));
            peliculaActores.Add(new PeliculaActor(peliculas[2], personas[1]));
            peliculaProductores.Add(new PeliculaProductor(peliculas[0], personas[6]));
            peliculaProductores.Add(new PeliculaProductor(peliculas[1], personas[7]));
            peliculaProductores.Add(new PeliculaProductor(peliculas[2], personas[8]));
        }

        private static void SaveData(List<Persona> personas, List<Estudio> estudios, List<Pelicula> peliculas, List<PeliculaActor> peliculaActores, List<PeliculaProductor> peliculaProductores)
        {
            String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Personas.txt");
            FileStream fs = new FileStream(fileName, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, personas);
            fs.Close();

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Estudios.txt");
            fs = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fs, estudios);
            fs.Close();

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Peliculas.txt");
            fs = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fs, peliculas);
            fs.Close();

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../PeliculaActores.txt");
            fs = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fs, peliculaActores);
            fs.Close();

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../PeliculaProductores.txt");
            fs = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fs, peliculaProductores);
            fs.Close();


        }

        private Boolean LoadData()
        {
            String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Personas.txt");
            if (!File.Exists(fileName))
            {
                return false;
            }
            FileStream fs = new FileStream(fileName, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            List<Persona> people = formatter.Deserialize(fs) as List<Persona>;
            foreach (Persona p in people) personas.Add(p);
            fs.Close();
            File.Delete(fileName);

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Estudios.txt");
            fs = new FileStream(fileName, FileMode.Open);
            List<Estudio> est = formatter.Deserialize(fs) as List<Estudio>;
            foreach (Estudio e in est) estudios.Add(e);
            fs.Close();
            File.Delete(fileName);

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Peliculas.txt");
            fs = new FileStream(fileName, FileMode.Open);
            List<Pelicula> pel = formatter.Deserialize(fs) as List<Pelicula>;
            foreach (Pelicula pe in pel) peliculas.Add(pe);
            fs.Close();
            File.Delete(fileName);

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../PeliculaActores.txt");
            fs = new FileStream(fileName, FileMode.Open);
            List<PeliculaActor> pela = formatter.Deserialize(fs) as List<PeliculaActor>;
            foreach (PeliculaActor pa in pela) peliculaActores.Add(pa);
            fs.Close();
            File.Delete(fileName);

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../PeliculaProductores.txt");
            fs = new FileStream(fileName, FileMode.Open);
            List<PeliculaProductor> pelp = formatter.Deserialize(fs) as List<PeliculaProductor>;
            foreach (PeliculaProductor pp in pelp) peliculaProductores.Add(pp);
            fs.Close();
            File.Delete(fileName);

            return true;
        }


    }
}
