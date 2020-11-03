using FreshFruit.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.Modal
{
    class Seller
    {
        private string name;
        private BucketController bucket;

        public Seller(string name, BucketController bucket)
        {
            this.name = name;
            this.bucket = bucket;
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }

        public void addFruit(Fruit fruit)
        {
            this.bucket.addFruit(fruit);
        }
        public void removeFruit(Fruit fruit)
        {
            this.bucket.removeFruit(fruit);
        }
    }
}
