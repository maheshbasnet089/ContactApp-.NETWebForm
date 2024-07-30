using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class ContactInfo
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public short AddressId { get; set; }
        public string Phone { get; set; }
    }
    public class AddressList
    {
        public short AddressId{ get; set; }
        public string AddressName { get; set; }
        public string PostalCode { get; set; }

    }
}
