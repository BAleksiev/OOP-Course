package shapes.spaceShape;

import java.util.Arrays;

public class Cuboid extends SpaceShape {

    private double width;
    private double height;
    private double depth;

    public Cuboid(double[] vertex, double width, double height, double depth) throws Exception {
        super(vertex);
        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);
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

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) throws Exception {
        if (depth <= 0) {
            throw new Exception("The depth should be positive number.");
        }
        this.depth = depth;
    }

    @Override
    public double getArea() {
        return 2 * ((this.getDepth() * this.getWidth()) + (this.getWidth() * this.getHeight()) + (this.getHeight() * this.getDepth()));
    }

    @Override
    public double getVolume() {
        return this.getWidth() * this.getHeight() * this.getDepth();
    }
    
    @Override
    public String toString() {
        return "Cuboid:"
                + "\n\tVertex: " + Arrays.toString(this.vertex)
                + "\n\tWidth: " + this.getWidth()
                + "\n\tHeight: " + this.getHeight()
                + "\n\tDepth: " + this.getDepth()
                + "\n\tArea: " + this.getArea()
                + "\n\tVolume: " + this.getVolume();
    }

}
