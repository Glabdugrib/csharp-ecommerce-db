namespace csharp_ecommerce_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EcommerceContext db = new EcommerceContext())
            {
                //*** Creazione prodotti

                    //Product prod1 = new Product("Bicicletta", "Bici da corsa con cambio Shimano", 299);
                    //Product prod2 = new Product("Videogioco", "Videogioco per PS5", 40);
                    //Product prod3 = new Product("T-Shirt", "T-Shirt bianca taglia M", 19);

                    //db.Add(prod1);
                    //db.Add(prod2);
                    //db.Add(prod3);
                    //db.SaveChanges();

                    //Creazione utenti
                    //Customer cust1 = new Customer("Simone", "Sada", "si.sada93@gmail.com");
                    //Customer cust2 = new Customer("Gianni", "Mario", "gianni.mario@gmail.com");

                    //db.Add(cust1);
                    //db.Add(cust2);
                    //db.SaveChanges();


                // *** Creazione ordini

                    //Order order1 = new Order(5, DateTime.Now, "delivered");
                    //Order order2 = new Order(5, DateTime.Now, "delivered");
                    //Order order3 = new Order(5, DateTime.Now, "preparing");
                    //Order order4 = new Order(6, DateTime.Now, "preparing");
                    //Order order5 = new Order(6, DateTime.Now, "delivered");

                    //db.Add(order1);
                    //db.Add(order2);
                    //db.Add(order3);
                    //db.Add(order4);
                    //db.Add(order5);


                // *** Creazione orders_products

                    //OrdersProducts ordPrd1 = new OrdersProducts(7, 4, 1);
                    //OrdersProducts ordPrd2 = new OrdersProducts(8, 4, 2);
                    //OrdersProducts ordPrd3 = new OrdersProducts(9, 5, 3);
                    //OrdersProducts ordPrd4 = new OrdersProducts(7, 6, 1);
                    //OrdersProducts ordPrd5 = new OrdersProducts(8, 6, 2);
                    //OrdersProducts ordPrd6 = new OrdersProducts(9, 7, 3);
                    //OrdersProducts ordPrd7 = new OrdersProducts(7, 8, 1);
                    //OrdersProducts ordPrd8 = new OrdersProducts(8, 8, 2);

                    //db.Add(ordPrd1);
                    //db.Add(ordPrd2);
                    //db.Add(ordPrd3);
                    //db.Add(ordPrd4);
                    //db.Add(ordPrd5);
                    //db.Add(ordPrd6);
                    //db.Add(ordPrd7);
                    //db.Add(ordPrd8);

                    //db.SaveChanges();


                // *** Recuperare lista ordini di un cliente
                //{
                //    List<Order> orders = db.Order.Where(order => order.CustomerId == 5).ToList();

                //    Console.WriteLine("\n\n*** Ordini del cliente 5 ***");
                //    foreach (Order order in orders)
                //    {
                //        order.PrintInfo();
                //    }
                //}



                // *** Modificare un ordine di un cliente
                //{
                //    Order updatedOrder = db.Order.Where(order => order.CustomerId == 5).First();

                //    updatedOrder.Status = "Lost";
                //    db.SaveChanges();

                //    List<Order> orders = db.Order.Where(order => order.CustomerId == 5).ToList();

                //    Console.WriteLine("\n\n*** Ordini del cliente 5 ***");
                //    foreach (Order order in orders)
                //    {
                //        order.PrintInfo();
                //    }
                //}


                // *** Eliminare un ordine di un cliente
                //{
                //    Order deletedOrder = db.Order.Where(order => order.CustomerId == 5).First();

                //    db.Remove(deletedOrder);
                //    db.SaveChanges();

                //    List<Order> orders = db.Order.Where(order => order.CustomerId == 5).ToList();

                //    Console.WriteLine("\n\n*** Ordini del cliente 5 ***");
                //    foreach (Order order in orders)
                //    {
                //        order.PrintInfo();
                //    }
                //}

                // *** Eliminare un prodotto su cui è attivo un ordine
                {
                    Product deletedProduct = db.Product.Where(product => product.Id == 9).First();

                    db.Remove(deletedProduct);
                    db.SaveChanges();

                    List<Order> orders = db.Order.Where(order => order.CustomerId == 5).ToList();

                    Console.WriteLine("\n\n*** Ordini del cliente 5 ***");
                    foreach (Order order in orders)
                    {
                        order.PrintInfo();
                    }
                }
            }
        }
    }
}
