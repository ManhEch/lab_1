using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Maps
    {
        public string ID { get; set; }
        public string Name { get; set; }
        private static string _inGame = "liên minh huyền thoại";

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public string ShowData()
        {
            return $"ID: {ID}, Name: {Name}, InGame: {_inGame}";
        }

    }
}
