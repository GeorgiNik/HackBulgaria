namespace Points
{
    public class Startup
    {
        public static void Main()
        {
            var pointInputed = ConsoleLogic.ReadInput();
            var directionsInputed = ConsoleLogic.ReadInput();

            IMovable point = new MovingPoint();
            var startingPoint = point.GetStartingPoint(pointInputed);
            var resultPointAfterMoving = point.Move(startingPoint, directionsInputed);
            ConsoleLogic.WriteAnswer(resultPointAfterMoving.X,resultPointAfterMoving.Y);
        }
    }
}