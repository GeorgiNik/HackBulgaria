namespace Points
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class MovingPoint:IMovable
    {
        public Point GetStartingPoint(string input)
        {
            var x = 0;
            var y = 0;
            var regex = new Regex(@"-?\d+");
            var match = regex.Match(input);

            if (match.Success)
            {
                x = int.Parse(match.Value);
            }
            match.NextMatch();
            if (match.Success)
            {
                y = int.Parse(match.Value);
            }

            return new Point(x, y);
        }

        public Point Move(Point point, string moves)
        {
            var x = point.X;
            var y = point.Y;
            var increase = 1;
            var decrease = -1;

            for (var i = 0; i < moves.Length; i++)
            {
                if (moves[i] == '~')
                {
                    increase = -1;
                    decrease = 1;
                }
                switch (moves[i])
                {
                    case '>':
                        x += increase;
                        break;
                    case '<':
                        x += decrease;
                        break;
                    case '^':
                        y += increase;
                        break;
                    case 'v':
                        y += decrease;
                        break;
                }
            }

            return new Point(x, y);
        }
    }
}