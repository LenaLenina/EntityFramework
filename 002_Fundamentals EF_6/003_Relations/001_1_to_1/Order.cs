﻿namespace _001_1_to_1
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }  
    }
}
