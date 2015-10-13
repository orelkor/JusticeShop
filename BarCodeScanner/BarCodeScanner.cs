using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCodeScanner
{
    public class BarcodeScanner : IBarCodeScanner
    {
        public BarCode ProvideBarCode()
        {
            return new BarCode();
        }
    }
}
