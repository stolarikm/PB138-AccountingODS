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
        /// Serializes the list of invoices to the XML format
        /// </summary>
		void Serialize(IList<Data.Invoice> invoices);

        /// <summary>
        /// Deserializes XML document to list of invoices
        /// </summary>
        IList<Data.Invoice> DeSerialize(string filename);


    }
}
