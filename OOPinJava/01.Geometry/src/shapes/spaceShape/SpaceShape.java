package shapes.spaceShape;

import shapes.Shape;
import shapes.AreaMeasurable;
import shapes.VolumeMeasurable;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {

    public SpaceShape(double[] vertex) {
        this.vertex = new double[2];
        this.vertex = vertex;
    }
}
