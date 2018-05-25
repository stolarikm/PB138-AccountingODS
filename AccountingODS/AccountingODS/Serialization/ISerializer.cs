using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingODS.Serialization
{
    public interface ISerializer
    {

        /// <summary>
        /// Serializes the invoice to the XML format
        /// </summary>
        void Serialize();

    }
}
