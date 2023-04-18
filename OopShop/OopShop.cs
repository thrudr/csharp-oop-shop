using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShop
{
    public class Article
    {
        // FEATURES
        private int code;
        private string name;
        private string description;
        private float price;
        private int iva;

        // CONSTRUCTORS

        public Article()
        {
            this.code = RandomCode();
        }

        public Article(string name, string description, float price, int iva)
        {
            this.code = RandomCode();
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;
        }

        // GETTERS

        public int GetCode()
        {
            return this.code;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public int GetIVA()
        {
            return this.iva;
        }


        //METHODS

        private int RandomCode()
        {
            Random random = new Random();
            int RandomCode = random.Next(99999999 + 1);
            return RandomCode;
        }
    }
}