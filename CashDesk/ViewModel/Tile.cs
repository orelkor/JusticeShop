using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashDesk.ViewModel
{
    public class Tile : Panel
    {
        public int TileNumber { get; private set; }
        public string TileName { get; private set; }
        public string TileCount { get; private set; }
        public string TilePrice { get; private set; }
        public string TileTotal { get; private set; }

        //public Tile()
        //{
        //    Controls.Add(new Label());
        //    Location = new Point();
        //}
    }
}
