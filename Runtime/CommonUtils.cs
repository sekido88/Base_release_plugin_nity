using UnityEngine;
using System.Collections.Generic;
using System;
public enum  Direction {
    Up,
    Right,
    Down,
    Left,
}
public static class CommonUtils
{
    // test su xinh gai
    // test do dep trai
    // test lan 2
    public static Dictionary<Direction, Vector3> directionToVector3 = new Dictionary<Direction, Vector3>() {
        {Direction.Up, Vector3.up},
        {Direction.Right , Vector3.right},
        {Direction.Down , Vector3.down},
        {Direction.Left , Vector3.left}
    };
    public static Dictionary<Direction, Vector2> directionToVector2 = new Dictionary<Direction, Vector2>() {
        {Direction.Up, Vector2.up},
        {Direction.Right , Vector2.right},
        {Direction.Down , Vector2.down},
        {Direction.Left , Vector2.left}
    };
    public static Direction GetOppositeDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Left: return Direction.Right;
            case Direction.Right: return Direction.Left;
            case Direction.Up: return Direction.Down;
            case Direction.Down: return Direction.Up;
        }
        return Direction.Up;
    }
    public static Dictionary<Direction, float> directionToRotation = new Dictionary<Direction, float>() {
        {Direction.Up, 0},
        {Direction.Right, 270f},
        {Direction.Down, 180f},
        {Direction.Left, 90f},
    };
    public static Dictionary<Direction, int> directionToRotate = new Dictionary<Direction, int>() {
        {Direction.Up, 0},
        {Direction.Right, 1},
        {Direction.Down, 2},
        {Direction.Left, 3},
    };
    public static Direction GetRotateDirection(Direction currentDirection,int rotate) {
        Direction[] directions = (Direction[])Enum.GetValues(typeof(Direction));
        int nextIndex = (directionToRotate[currentDirection] + rotate) % 4;
        
        return directions[nextIndex];
    }


    public static void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
    
}