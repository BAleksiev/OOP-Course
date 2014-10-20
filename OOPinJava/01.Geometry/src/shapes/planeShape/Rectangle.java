package shapes.planeShape;

import java.util.Arrays;

public class Rectangle extends PlaneShape {

    private double width;
    private double height;

    public Rectangle(double[] vertex, double width, double height) throws Exception {
        super(vertex);
        this.setWidth(width);
        this.setHeight(height);
    }

    public double getWidth() {
        return this.width;
    }

    public void setWidth(double widht) throws Exception {
        if (widht <= 0) {
            throw new Exception("The width should be positive number.");
        }
        this.width = widht;
    }

    public double getHeight() {
        return this.height;
    }

    public void setHeight(double height) throws Exception {
        if (height <= 0) {
            throw new Exception("The height should be positive number.");
        }
        this.height = height;
    }

    @Override
    public double getArea() {
        return this.getWidth() * this.getHeight();
    }

    @Override
    public double getPerimeter() {
        return (this.getWidth() * this.getWidth()) + (this.getHeight() * this.getHeight());
    }
    
    @Override
    public String toString() {
        return "Rectangle:"
                + "\n\tVertex: " + Arrays.toString(this.vertex)
                + "\n\tPerimeter: " + this.getPerimeter()
                + "\n\tArea: " + this.getArea();
    }

}
