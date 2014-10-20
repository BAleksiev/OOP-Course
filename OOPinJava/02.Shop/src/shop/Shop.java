package shop;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
import product.Expirable;
import product.FoodProduct;
import product.Product;

public class Shop {

    public static void main(String[] args) throws Exception {

        FoodProduct bread = new FoodProduct("Bread", 1, 10, AgeRestriction.None, "16.10.2014");
        FoodProduct milk = new FoodProduct("Milk", 2, 50, AgeRestriction.None, "16.11.2014");
        FoodProduct cigars = new FoodProduct("Cigars", 6, 50, AgeRestriction.Adult, "16.11.2014");
        FoodProduct apples = new FoodProduct("Apples", 2, 0, AgeRestriction.Adult, "16.11.2014");

        Customer dimitarPetrov = new Customer("Gosho Georgiev", 15, 100);
        Customer asenIvanov = new Customer("Pesho Peshev", 14, 2.7);
        Customer ivanSimeonov = new Customer("Tosho Toshev", 24, 15.5);

        try {
            PurchaseManager.processPurchase(bread, dimitarPetrov);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        try {
            PurchaseManager.processPurchase(cigars, dimitarPetrov);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        try {
            PurchaseManager.processPurchase(milk, asenIvanov);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        try {
            PurchaseManager.processPurchase(apples, ivanSimeonov);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }

        List<Product> products = new ArrayList<>();
        products.add(bread);
        products.add(milk);
        products.add(cigars);
        products.add(apples);

        Product productWithMostRecentExpirationDate = products.stream()
                .filter(p -> p instanceof Expirable)
                .map(p -> (Expirable) p)
                .sorted((p1, p2) -> p1.getExpirationDate().compareTo(p2.getExpirationDate()))
                .map(p -> (Product) p)
                .findFirst()
                .get();

        System.out.println(productWithMostRecentExpirationDate.getName());
        System.out.println();

        products.stream()
                .filter(p -> p.getAgeRestriction() == AgeRestriction.Adult)
                .sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
                .collect(Collectors.toList())
                .forEach(p -> System.out.println(p.getName() + " price: " + p.getPrice()));
    }
}
