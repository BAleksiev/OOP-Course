package product.electronicsProduct;

import product.Product;
import shop.AgeRestriction;

public abstract class ElectronicsProduct extends Product {

    private int guaranteePeriod;
    
    public ElectronicsProduct(String name, double price, int quantity, AgeRestriction ageRestriction)
            throws Exception {
        super(name, price, quantity, ageRestriction);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) throws Exception {
        if(guaranteePeriod < 0) {
            throw new Exception("Guarantee period can't be negative number!");
        }
        this.guaranteePeriod = guaranteePeriod;
    }
    
}
