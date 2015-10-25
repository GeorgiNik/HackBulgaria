namespace Points
{
    public interface IMovable
    {
        Point Move(Point point, string moves);

        Point GetStartingPoint(string input);
    }
}