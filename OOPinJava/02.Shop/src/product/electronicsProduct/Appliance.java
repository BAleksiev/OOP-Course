
package product.electronicsProduct;

import shop.AgeRestriction;

public class Appliance extends ElectronicsProduct {

    private static final int productGuaranteePeriod = 6;
    
    public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction) throws Exception {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(productGuaranteePeriod);
    }
    
    @Override
    public double getPrice() {
        if(this.getQuantity() < 50) {
            return super.getPrice() * 1.05;
        }
        
        return super.getPrice();
    }
}
