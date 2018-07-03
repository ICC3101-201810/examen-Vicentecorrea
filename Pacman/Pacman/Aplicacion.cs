using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    [Serializable()]
    class Aplicacion
    {
        public static List<Usuario> usuarios = new List<Usuario>();

        public static Usuario IniciarSesion(string nombre)
        {
            foreach (Usuario usuarioExistente in usuarios)
            {
                if (usuarioExistente.nombre == nombre)
                {
                    return usuarioExistente;
                }
            }
            Usuario nuevoUsuario = new Usuario(nombre);
            usuarios.Add(nuevoUsuario);
            return nuevoUsuario;
        }

        public static string InfoHistorica()
        {
            string info = "";
            foreach (Usuario u in usuarios)
            {
                info += $"NOMBRE: {u.nombre}" + $"\t-\tPUNTAJE MAXIMO: {u.puntaje}\n";
            }
            return info;
        }

        public static void SerializarTodo()
        {
            try
            {
                using (Stream stream = File.Open("../../usuariosData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter datosSerializacion = new BinaryFormatter();
                    datosSerializacion.Serialize(stream, usuarios);
                }
            }
            catch (IOException) { }
        }
        public static void DeSerializarTodo()
        {
            try
            {
                using (Stream stream = File.Open("../../usuariosData.bin", FileMode.Open))
                {
                    BinaryFormatter usuariosData = new BinaryFormatter();

                    var usuariosSerializados = (List<Usuario>)usuariosData.Deserialize(stream);
                    foreach (Usuario u in usuariosSerializados)
                    {
                        usuarios.Add(u);

                    }
                }
            }
            catch (IOException) { }
        }
    }
}