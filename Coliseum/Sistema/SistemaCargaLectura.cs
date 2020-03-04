using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Sistema
{
    public class SistemaCargaLectura
    {
        string path = @"C:\Users\atorchia\Desktop\ColiseumSave.json";
        public List<Partida> cargarPartidas()
        {
            List<Partida> resultado;
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                resultado = JsonConvert.DeserializeObject<List<Partida>>(json);
            }
            return resultado;
        }
        public void guardarPartidas(List<Partida> partidas)
        {
            string json = JsonConvert.SerializeObject(partidas);
            System.IO.File.WriteAllText(path, json);
        }
    }
}
