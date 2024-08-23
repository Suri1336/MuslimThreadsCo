using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if(context.Products.Any())return;

            var products = new List<Product>
            {
           
                 		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
                   		new Product
                {
                    Name = "Embroidery Brown Kefiyyeh Abaya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/Users/sarauri/MuslimThreadsCo/images/Screenshot 2024-08-16 at 9.38.49 PM.png",
                    Brand = "Muslim Threads",
                    Type = "Abaya",
                    QuantityInStock = 100
                },
            };
            //Can be done this way where you can pass in your products as a list 
            // context.Products.AddRange(products);

            //this foreach is looping throw each item/products
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();  //this method will allow you to save to the changes made to the data base
        }
    }
}