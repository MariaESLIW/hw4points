
hw4point.Point[] points = new hw4point.Point[10];

points[0] = new hw4point.Point(5, 7);
points[1] = new hw4point.Point(3, 7);
points[2] = new hw4point.Point(-5, -7);
points[3] = new hw4point.Point(-3, -7);
points[4] = new hw4point.Point(7, 9);
points[5] = new hw4point.Point(5, 9);
points[6] = new hw4point.Point(-7, -9);
points[7] = new hw4point.Point(-5, -9);
points[8] = new hw4point.Point(1, 7);
points[9] = new hw4point.Point(-1, -7);

for(int i=0; i<points.Length; i++)
{
    points[i].printPoint();
}

