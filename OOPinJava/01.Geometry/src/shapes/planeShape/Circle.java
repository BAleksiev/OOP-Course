package shapes.planeShape;

import java.util.Arrays;

public class Circle extends PlaneShape {

    private double radius;

    public Circle(double[] vertex, double radius) throws Exception {
        super(vertex);
        this.setRadius(radius);
    }

    public double getRadius() {
        return this.radius;
    }

    public void setRadius(double radius) throws Exception {
        if (radius <= 0) {
            throw new Exception("The radius should be positive number.");
        }
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return Math.PI * this.getRadius() * this.getRadius();
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * this.getRadius();
    }
    
    @Override
    public String toString() {
        return "Circle:"
                + "\n\tVerex: " + Arrays.toString(this.vertex)
                + "\n\tRadius: " + this.getRadius()
                + "\n\tPerimeter: " + this.getPerimeter()
                + "\n\tArea: " + this.getArea();
    }
}
