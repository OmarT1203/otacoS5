using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otacoS5.Modelos;
using SQLite;

namespace otacoS5.Clases
{
    public class PersonRepository
    {
        string ruta;
        private SQLiteConnection conn;
        public string mensaje {  get; set; }
        private void init()
        {
            if (conn is not null)
                return;
            conn = new(ruta);
            conn.CreateTable<Persona>();
        }
        public PersonRepository(string path)
        {
            ruta= path; //asigno un valor
        }

        public void AddNewPerson(string nombre)
        {
            int result = 0;
            try
            {
                init();
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("Nombre requerido");
                Persona persona = new() { Name = nombre };
                result = conn.Insert(persona); //
                mensaje = string.Format("Dato ingresado");
            }
            catch (Exception ex)
            {
                mensaje=string.Format("Error" + ex.Message);
            }
        }

        public List<Persona> GetAllPeople()
        {
            try
            {
                init(); //Listar todas las personas
                return conn.Table<Persona>().ToList();
            }
            catch (Exception ex)
            {
                mensaje = string.Format("Error" + ex.Message);
            }
            return new List<Persona>(); //Lista con los datos
        }

        //DELETE
        //UPDATE
    }
}

