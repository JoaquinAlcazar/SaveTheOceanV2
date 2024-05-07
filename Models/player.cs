using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SaveTheOceanLib
{
    public class player
    {
        protected type playerType { get; set; }
        public int experience { get; set; } = 0;
        public string name { get; set; }

        public player()
        {
            this.playerType = type.tecnic;
            this.experience = 0;
            this.name = "Placeholder";
        }
        public void selectType(string type)
        {
            if (type == "Tecnic")
            {
                this.playerType = SaveTheOceanLib.type.tecnic;
            }
            else if (type == "Veterinari")
            {
                this.playerType = SaveTheOceanLib.type.veterinari;
            }
        }

        public void selectName(string name)
        {
            this.name = name;
        }

        // Método para guardar los datos del jugador en un archivo XML
        public void SaveToXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(player));
            using (TextWriter writer = new StreamWriter(@"./../../../Files/player.xml"))
            {
                serializer.Serialize(writer, this);
            }
        }

        // Método estático para cargar los datos de un jugador desde un archivo XML
        public static player LoadFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(player));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (player)serializer.Deserialize(reader);
            }
        }
    }
}
