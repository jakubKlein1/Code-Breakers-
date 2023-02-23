public static string[] DirectionsSolution(string[] arr)
{
    Stack<string> stack = new Stack<string>();
    foreach (string direction in arr)
    {
        if (stack.Count > 0 && stack.Peek() == OppositeDirection(direction))
        {
            stack.Pop();
        }
        else
        {
            stack.Push(direction);
        }
    }
    string[] result = stack.ToArray();
    Array.Reverse(result);
    return result;
}

private static string OppositeDirection(string direction)
{
    switch (direction)
    {
        case "NORTH":
            return "SOUTH";
        case "SOUTH":
            return "NORTH";
        case "EAST":
            return "WEST";
        case "WEST":
            return "EAST";
        default:
            throw new ArgumentException("Invalid direction: " + direction);
    }
}
