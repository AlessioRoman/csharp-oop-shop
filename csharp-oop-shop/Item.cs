using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace items
{
    internal class Item
    {
        private string code = null;
        private string name;
        private string description;
        private float priceNoIva;
        private float priceIva;
        internal Item next;

        public Item(string name = "", string description = "", float priceNoIva = 0)
        {

            Random random = new Random();

            this.code = ((random.Next(1, 1000)).ToString()).PadLeft(8, '0');

            this.name = name;
            this.description = description;
            this.priceNoIva = priceNoIva;
            this.priceIva = priceNoIva + (priceNoIva * 0.22f);
            this.next = null;
        }

        public string getCode()
        {
            return code;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDescription(string description) 
        { 
            this.description = description;
        }

        public void setPriceNoIva(float priceNoIva) 
        {
            this.priceNoIva = priceNoIva;
            this.priceIva = priceNoIva + (priceNoIva * 0.22f);
        }

        public void setPriceIva(float priceIva)
        {
            this.priceIva = priceIva;
            this.priceNoIva = priceIva * 0.78f;
        }

        public string getFullName() 
        { 
            return this.code + " " + this.name;
        }

        public string getName() 
        {
            return name;
        }

        public float getPriceNoIva()
        { 
            return priceNoIva;
        }

        public float getPriceIva()
        {
            return priceIva;
        }
    }
}
