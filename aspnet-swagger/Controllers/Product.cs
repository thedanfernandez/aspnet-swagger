
namespace aspnet_swagger
{
    /// <summary>
    /// Represents a single product in the product catalog
    /// </summary>
    public class Product
    {
        /// <param name="ID">A sequential unique identifier for a product.</param>
        public int ID { get; set; }

        /// <param name="Name">The product's name.</param>
        public string Name { get; set; }
        /// <param name="Price">The Product price as an integer in US currency.</param>
        public int Price { get; set; }

        /// <param name="Description">A 300 character description of the product</param>
        public string Description { get; set; }


    }
}