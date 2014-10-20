package shop;

import java.sql.Date;
import java.time.LocalDate;
import product.Expirable;
import product.Product;

public class PurchaseManager {

    public static void processPurchase(Product product, Customer customer) throws Exception {

        if (product.getQuantity() <= 0) {
            throw new Exception(product.getName() + " is out of stock!");
        }

        if (product instanceof Expirable) {
            Expirable expirableProduct = (Expirable) product;
            Date now = Date.valueOf(LocalDate.now());

            if (expirableProduct.getExpirationDate().before(now)) {
                throw new RuntimeException(product.getName() + " is past its date.");
            }
        }

        if (customer.getBalance() < product.getPrice()) {
            throw new Exception("You do not have enough money to buy this product!");
        }

        if (product.getAgeRestriction() != AgeRestriction.None) {
            if (customer.getAge() < 18 && product.getAgeRestriction() == AgeRestriction.Adult) {
                throw new Exception("You are too young to buy this product!");
            }
            if (customer.getAge() >= 18 && product.getAgeRestriction() == AgeRestriction.Teenager) {
                throw new Exception("You are too old to buy this product!");
            }
        }
    }

}
