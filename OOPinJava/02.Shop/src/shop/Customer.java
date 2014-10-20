
package shop;

public class Customer {
    
    private String name;
    private int age;
    private double balance;
    
    public Customer(String name, int age, double balance) throws Exception {
        this.setName(name);
        this.setAge(age);
        this.setBalance(balance);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) throws Exception {
        if(name.length() <= 0) {
            throw new Exception("Name is required");
        }
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) throws Exception {
        if(age <= 0 || age > 150) {
            throw new Exception("Invalid age input!");
        }
        this.age = age;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) throws Exception {
        if(balance < 0) {
            throw new Exception("Can't add negative price to customer balance!");
        }
        this.balance = balance;
    }
    
}
