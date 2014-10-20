package shapes.spaceShape;

import java.util.Arrays;

public class Sphere extends SpaceShape {

    private double radius;

    public Sphere(double[] vertex, double radius) throws Exception {
        super(vertex);
        this.setRadius(radius);
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) throws Exception {
        if (radius <= 0) {
            throw new Exception("The radius should be positive number.");
        }
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return 4 * Math.PI * (this.getRadius() * this.getRadius());
    }

    @Override
    public double getVolume() {
        return 4 * (Math.PI * (this.getRadius() * this.getRadius() * this.getRadius())) / 3;
    }

    @Override
    public String toString() {
        return "Sphere:"
                + "\n\tVertex: " + Arrays.toString(this.vertex)
                + "\n\tRadius: " + this.getRadius()
                + "\n\tArea: " + this.getArea()
                + "\n\tVolume: " + this.getVolume();
    }
}
