
package inheritancedemo;

class Vehicle{
    public Vehicle() {
        System.out.println("Create vihicle");
    }
}

public class Bike extends Vehicle {
    public Bike() {
        super(); // gọi constructor của lớp cha
        System.out.println("Create bike");
    }
    public static void main(String[]args) {
        Bike b = new Bike();
    }
    
}
