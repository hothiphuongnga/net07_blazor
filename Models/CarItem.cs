namespace buoi18.Models;
public class CarItemVM
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }

    public CarItemVM(string name, decimal price, string image,  string description)
    {
        Name = name;
        Price = price;
        Image = image;
        Description = description;
    }

}