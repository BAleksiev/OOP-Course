package shapes.planeShape;

import java.util.Arrays;

public class Triangle extends PlaneShape {

    protected double[] vertex2 = new double[2];
    protected double[] vertex3 = new double[2];

    public Triangle(double[] vertex, double[] vertex2, double[] vertex3) {
        super(vertex);
        this.vertex2 = vertex2;
        this.vertex3 = vertex3;
    }

    @Override
    public double getArea() {
        double halfP = getPerimeter() / 2;
        double a = distanceBetweenTwoPoints(this.vertex, this.vertex2);
        double b = distanceBetweenTwoPoints(this.vertex2, this.vertex3);
        double c = distanceBetweenTwoPoints(this.vertex3, this.vertex);
        
        return Math.sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
    }

    @Override
    public double getPerimeter() {
        double a = distanceBetweenTwoPoints(this.vertex, this.vertex2);
        double b = distanceBetweenTwoPoints(this.vertex2, this.vertex3);
        double c = distanceBetweenTwoPoints(this.vertex3, this.vertex);
        
        return a + b + c;
    }

    @Override
    public String toString() {
        return "Triangle:"
                + "\n\ta:" + Arrays.toString(this.vertex)
                + "\n\tb:" + Arrays.toString(this.vertex2)
                + "\n\tc:" + Arrays.toString(this.vertex3)
                + "\n\tPerimeter: " + this.getPerimeter()
                + "\n\tArea: " + this.getArea();
    }

    public double distanceBetweenTwoPoints(double[] vertex, double[] vertex2) {

        double x = vertex[0] - vertex2[0];
        double y = vertex[1] - vertex2[1];
        return Math.sqrt(x * x + y * y);

    }
}
