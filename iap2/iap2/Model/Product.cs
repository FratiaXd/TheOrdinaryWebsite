namespace iap2.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public string ProductImageAlt { get; set; }

        //more images for single prod page
    }
}
