
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;
import shapes.PerimeterMeasurable;
import shapes.Shape;
import shapes.planeShape.Circle;
import shapes.planeShape.Rectangle;
import shapes.planeShape.Triangle;
import shapes.spaceShape.Cuboid;
import shapes.spaceShape.SpaceShape;
import shapes.spaceShape.Sphere;
import shapes.spaceShape.SquarePyramid;

public class Geometry {

    public static void main(String[] args) throws Exception {

        double[] a = {2, 2};
        double[] b = {4, 3};
        double[] c = {2, 5};

        Shape triangle = new Triangle(a, b, c);
        Shape rectangle = new Rectangle(a, 20, 10);
        Shape circle = new Circle(a, 5);
        Shape pyramid = new SquarePyramid(a, 5, 6);
        Shape cuboid = new Cuboid(a, 6, 5, 8);
        Shape sphere = new Sphere(a, 5);

        Shape[] shapes = {triangle, rectangle, circle, pyramid, cuboid, sphere};

        System.out.println("Shapes:\n----------------------");
        for (Shape shape : shapes) {
            System.out.println(shape);
        }

        List<SpaceShape> shapeList = Arrays.asList(shapes).stream()
                .filter(s -> s instanceof SpaceShape).map(s -> (SpaceShape) s)
                .filter(v -> v.getVolume() > 40).collect(Collectors.toList());

        System.out.println("\nShapes sorted by volume over 40\n---------------------------------");
        shapeList.stream().forEach((shape) -> {
            System.out.println(shape);
        });

        Comparator<PerimeterMeasurable> comparatorByPerimeter
                = (PerimeterMeasurable s1, PerimeterMeasurable s2) -> {
                    double diff = s1.getPerimeter() - s2.getPerimeter();
                    if (diff < 0) {
                        return -1;
                    }

                    if (diff > 0) {
                        return 1;
                    }

                    return 0;
                };

        List<PerimeterMeasurable> SortedShapes = Arrays.asList(shapes).stream()
                .filter(s -> s instanceof PerimeterMeasurable)
                .map(s -> (PerimeterMeasurable) s)
                .sorted(comparatorByPerimeter)
                .collect(Collectors.toList());

        System.out.println("\nShapes sorted by perimeter (ASC)\n----------------------------------");
        SortedShapes.stream().forEach((shape) -> {
            System.out.println(shape);
        });
    }
}
