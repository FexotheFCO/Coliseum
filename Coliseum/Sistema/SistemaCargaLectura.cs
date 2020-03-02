using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Sistema
{
    public class SistemaCargaLectura
    {

        public void guardarPartida(Partida partida)
        {
            string json = JsonConvert.SerializeObject(partida);
            string path = @"C:\Users\atorchia\Desktop\ColiseumSave.json";
            System.IO.File.WriteAllText(path, json);
        }
    }
}
