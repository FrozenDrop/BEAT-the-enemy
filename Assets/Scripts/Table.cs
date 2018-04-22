using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour {

    private static readonly int ROWS = 10;
    public static int rows { get { return ROWS; } }

    private static readonly int COLS = 10;
    public static int cols { get { return COLS; } }

    public static Transform[,] table = new Transform[ROWS, COLS];

    public static void AddElement(Transform transform)
    {
        table[(int)transform.position.y, (int)transform.position.x] = transform;
    }
}
