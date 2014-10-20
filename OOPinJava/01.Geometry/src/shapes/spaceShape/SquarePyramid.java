package shapes.spaceShape;

import java.util.Arrays;

public class SquarePyramid extends SpaceShape {

    private double width;
    private double height;

    public SquarePyramid(double[] vertex, double width, double height) throws Exception {
        super(vertex);
        this.setWidth(width);
        this.setHeight(height);
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) throws Exception {
        if (width <= 0) {
            throw new Exception("The width should be positive number.");
        }
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) throws Exception {
        if (height <= 0) {
            throw new Exception("The height should be positive number.");
        }
        this.height = height;
    }

    @Override
    public double getArea() {
        double leteralArea = this.getWidth() * Math.sqrt((this.getWidth() * this.getWidth()) + (4 * (this.getHeight() * this.getHeight())));
        double baseArea = this.getWidth() * this.getWidth();
        return leteralArea + baseArea;
    }

    @Override
    public double getVolume() {
        return ((this.getWidth() * this.getWidth()) * this.getHeight()) / 3;
    }
    
    @Override
    public String toString() {
        return "Square Pyramid:"
                + "\n\tVertex: " + Arrays.toString(this.vertex)
                + "\n\tWidth: " + this.getWidth()
                + "\n\tHeight: " + this.getHeight()
                + "\n\tArea: " + this.getArea()
                + "\n\tVolume: " + this.getVolume();
    }
}
