package shapes.planeShape;

import shapes.Shape;
import shapes.AreaMeasurable;
import shapes.PerimeterMeasurable;

public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable {

    public PlaneShape(double[] vertex) {
        this.vertex = new double[2];
        this.vertex = vertex;
    }
}
