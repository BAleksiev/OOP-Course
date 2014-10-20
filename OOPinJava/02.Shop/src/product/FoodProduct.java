package product;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;
import shop.AgeRestriction;

public class FoodProduct extends Product implements Expirable {

    private Date expirationDate;

    public FoodProduct(String name, double price, int quantity, AgeRestriction ageRestriction, String expirationDate) throws Exception {
        super(name, price, quantity, ageRestriction);
        this.setExpirationDate(expirationDate);
    }

    @Override
    public Date getExpirationDate() {
        return this.expirationDate;
    }
    
    public void setExpirationDate(String expirationDate) {
        SimpleDateFormat myFormat = new SimpleDateFormat("dd.MM.yyyy");
        
        try {
            this.expirationDate = myFormat.parse(expirationDate);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @Override
    public double getPrice() {
        Date now = new Date();
        long days = TimeUnit.DAYS.convert(this.getExpirationDate().getTime() - now.getTime(), TimeUnit.MILLISECONDS);
        
        if(days <= 15) {
            return super.getPrice() * 0.7;
        }
        
        return super.getPrice();
    }
}
