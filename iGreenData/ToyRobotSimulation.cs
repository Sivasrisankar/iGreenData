namespace Test.ConsoleApp
{
    public class ToyRobotSimulation
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        public void Place(int x, int y, string direction)
        {
            if (IsValidPosition(x, y))
            {
                X = x;
                Y = y;
                Direction = direction;
            }
        }

        public void Move()
        {
            switch (Direction)
            {
                case "NORTH":
                    if (IsValidPosition(X, Y + 1))
                        Y++;
                    break;

                case "SOUTH":
                    if (IsValidPosition(X, Y - 1))
                        Y--;
                    break;

                case "EAST":
                    if (IsValidPosition(X + 1, Y))
                        X++;
                    break;

                case "WEST":
                    if (IsValidPosition(X - 1, Y))
                        X--;
                    break;
            }
        }

        public void Left()
        {
            switch (Direction)
            {
                case "NORTH":
                    Direction = "WEST";
                    break;

                case "SOUTH":
                    Direction = "EAST";
                    break;

                case "EAST":
                    Direction = "NORTH";
                    break;

                case "WEST":
                    Direction = "SOUTH";
                    break;
            }
        }

        public void Right()
        {
            switch (Direction)
            {
                case "NORTH":
                    Direction = "EAST";
                    break;

                case "SOUTH":
                    Direction = "WEST";
                    break;

                case "EAST":
                    Direction = "SOUTH";
                    break;

                case "WEST":
                    Direction = "NORTH";
                    break;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Position: ({X}, {Y}), Direction: {Direction}");
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x <= 4 && y >= 0 && y <= 4;
        }

        public void ExecuteCommand(string command)
        {
            if (command.StartsWith("PLACE"))
            {
                string[] parameters = command.Split(' ')[1].Split(',');
                int x = int.Parse(parameters[0]);
                int y = int.Parse(parameters[1]);
                string direction = parameters[2];
                Place(x, y, direction);
            }
            else if (Direction != null)
            {
                switch (command)
                {
                    case "MOVE":
                        Move();
                        break;

                    case "LEFT":
                        Left();
                        break;

                    case "RIGHT":
                        Right();
                        break;

                    case "REPORT":
                        Report();
                        break;
                }
            }
        }
    }
}