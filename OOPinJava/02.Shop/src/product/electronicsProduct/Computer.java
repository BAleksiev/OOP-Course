package product.electronicsProduct;

import shop.AgeRestriction;

public class Computer extends ElectronicsProduct {
    
    private static final int productGuaranteePeriod = 24;
    
    public Computer(String name, double price, int quantity, AgeRestriction ageRestriction) 
            throws Exception {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(productGuaranteePeriod);
    }
    
    @Override
    public double getPrice() {
        if(this.getQuantity() >= 1000) {
            return super.getPrice() * 0.95;
        }
        
        return super.getPrice();
    }
}
