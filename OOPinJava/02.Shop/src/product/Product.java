package product;

public abstract class Product implements Buyable {

    private String name;
    private double price;
    private int quantity;
    private AgeRestriction ageRestriction;
    
    public Product(String name, double price, AgeRestriction ageRestriction) throws Exception {
        this.setName(name);
        this.setPrice(price);
        this.setQuantity(quantity);
        this.setAgeRestriction(ageRestriction);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) throws Exception {
        if (name.length() <= 0) {
            throw new Exception("Name required!");
        }
        this.name = name;
    }

    @Override
    public double getPrice() {
        return price;
    }

    public void setPrice(double price) throws Exception {
        if(price < 0) {
            throw new Exception("Price can't be less than zero!");
        }
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
        this.ageRestriction = ageRestriction;
    }
}
