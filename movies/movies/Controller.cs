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
            View.OnSearch += SearchItems_OnSearch;
            View.OnButtonHit += LoadElements_OnButtonHit;
            View.OnSelection += LoadProfile_OnSelection;


            if (!LoadData())
            {
                InicializaUsuariosIniciales();
            }
            else
            {
                Persona.count = personas.Count;
                Estudio.count = estudios.Count;
                Pelicula.count = peliculas.Count;
            }

        }

        //Busqueda
        private void SearchItems_OnSearch(object sender, DataEventArgs e)
        {
            List<String> totalList = new List<String>();
            List<Persona> people = new List<Persona>();
            List<Estudio> studios = new List<Estudio>();
            List<Pelicula> movies = new List<Pelicula>();
            people = personas.Where(t =>
                t.nombre.ToUpper().Contains(e.searchWord.ToUpper()) ||
                t.apellido.ToUpper().Contains(e.searchWord.ToUpper()) ||
                t.biografia.ToUpper().Contains(e.searchWord.ToUpper()) ||
                t.ocupacion.ToUpper().Contains(e.searchWord.ToUpper()) ||
                t.fechaDeNacimiento.ToShortDateString().Contains(e.searchWord.ToUpper()))
            .ToList();
            if (people.Count > 0) {
                totalList.Add("-----Personas Encontradas-----");
                foreach (Persona p in people)
                    totalList.Add(p.ToString());
            }

            studios = estudios.Where(t =>
            t.nombre.ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.direccion.ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.fechaDeApertura.ToShortDateString().ToUpper().Contains(e.searchWord.ToUpper()))
            .ToList();

            if (studios.Count > 0)
            {
                totalList.Add("-----Estudios Encontrados-----");
                foreach (Estudio studio in studios)
                    totalList.Add(studio.ToString());
            }

            movies = peliculas.Where(t =>
            t.nombre.ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.director.nombre.ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.director.apellido.ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.fechaDeEstreno.ToShortDateString().ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.descripcion.ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.presupuesto.ToString().ToUpper().Contains(e.searchWord.ToUpper()) ||
            t.estudio.nombre.ToUpper().Contains(e.searchWord.ToUpper()))
            .ToList();

            if (movies.Count > 0)
            {
                totalList.Add("-----Peliculas Encontradas-----");
                foreach (Pelicula movie in movies)
                    totalList.Add(movie.ToString());
            }

            View.UpdateSearch(totalList);
        }
        //Seleccionar un Boton

        private void LoadElements_OnButtonHit(object sender, DataEventArgs e)
        {
            List<Persona> people = new List<Persona>();
            if (e.button.Equals("Peliculas"))
            {
                View.UpdateListAfterButton(peliculas);
            }
            if (e.button.Equals("Estudios"))
            {
                View.UpdateListAfterButton(estudios);
            }
            if (e.button.Equals("Actores"))
            {
                foreach (Persona p in personas)
                    if (p.ocupacion.Equals("actor"))
                        people.Add(p);
                View.UpdateListAfterButton(people);
            }
            if (e.button.Equals("Directores"))
            {
                foreach (Persona p in personas)
                    if (p.ocupacion.Equals("director"))
                        people.Add(p);
                View.UpdateListAfterButton(people);
            }
            if (e.button.Equals("Productores"))
            {
                foreach (Persona p in personas)
                    if (p.ocupacion.Equals("productor"))
                        people.Add(p);
                View.UpdateListAfterButton(people);
            }
            View.ShowPanelAfterButton();
        }
        //Seleccionar un elemento

        private void LoadProfile_OnSelection(object sender, DataEventArgs e)
        {
            List<Persona> people = new List<Persona>();
            List<Pelicula> movies = new List<Pelicula>();
            Dictionary<String,String> atributos = new Dictionary<String, String>();
            int index = -1;
            if (e.button.Equals("Peliculas"))
            {
                foreach (Pelicula p in peliculas)
                    if (p.id == e.movie.id)
                        index = peliculas.IndexOf(p);
                atributos.Add("Nombre", peliculas[index].nombre);
                atributos.Add("Director", String.Concat(peliculas[index].director.nombre," ", peliculas[index].director.apellido));
                atributos.Add("Estreno", peliculas[index].fechaDeEstreno.ToShortDateString());
                atributos.Add("Descripcion", peliculas[index].descripcion);
                atributos.Add("Presupuesto", peliculas[index].presupuesto.ToString());
                atributos.Add("Estudio", peliculas[index].estudio.nombre);

                foreach(PeliculaActor pa in peliculaActores)
                {
                    if (pa.pelicula.id == peliculas[index].id)
                        people.Add(pa.actor);
                }
                foreach (PeliculaProductor pa in peliculaProductores)
                {
                    if (pa.pelicula.id == peliculas[index].id)
                        people.Add(pa.productor);
                }
                View.UpdateElementsProfile(atributos);
                View.UpdateListProfile(people);
            }
            else if (e.button.Equals("Estudios"))
            {
                foreach (Estudio studio in estudios)
                    if (studio.id == e.studio.id)
                        index = estudios.IndexOf(studio);
                atributos.Add("Nombre", estudios[index].nombre);
                atributos.Add("Direccion", estudios[index].direccion);
                atributos.Add("Apertura", estudios[index].fechaDeApertura.ToShortDateString());
                foreach (Pelicula p in peliculas)
                {
                    if (p.estudio.id == estudios[index].id)
                        movies.Add(p);
                }
                View.UpdateElementsProfile(atributos);
                View.UpdateListProfile(movies);
            }
            else 
            {
                foreach (Persona person in personas)
                    if (person.id == e.person.id)
                        index = personas.IndexOf(person);
                atributos.Add("Nombre", String.Concat(personas[index].nombre, " ", personas[index].apellido));
                atributos.Add("Fecha de Nacimiento", personas[index].fechaDeNacimiento.ToShortDateString());
                atributos.Add("Ocupacion", personas[index].ocupacion);
                atributos.Add("Biografia", personas[index].biografia);
                foreach (PeliculaActor pa in peliculaActores)
                {
                    if (pa.actor.id == personas[index].id)
                        movies.Add(pa.pelicula);
                }
                foreach (PeliculaProductor pa in peliculaProductores)
                {
                    if (pa.productor.id == personas[index].id)
                        movies.Add(pa.pelicula);
                }
                foreach (Pelicula p in peliculas)
                {
                    if (p.director.id == personas[index].id)
                        movies.Add(p);
                }
                View.UpdateElementsProfile(atributos);
                View.UpdateListProfile(movies);
            }
           
            View.ShowPanelProfile();
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
            peliculas.Add(new Pelicula("Estudiando con Andres", personas[4], new DateTime(2017, 2, 5), "Una tarde des estudio con Kim", 1000000, estudios[1]));
            peliculas.Add(new Pelicula("Howard, Perez o Cea", personas[5], new DateTime(2018, 3, 5), "Carlos nos entrega una critica de Howardo", 1000000, estudios[2]));
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
