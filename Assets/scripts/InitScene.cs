using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScene : MonoBehaviour {

    const float fieldSize = 1F;

    [SerializeField]
    public List<GameObject> tiles;   

    // Use this for initialization
    void Start () {
        Screen.SetResolution(1280, 720, true);
                
        for (int y = 0, _y = Table.rows; y < _y; y++)
        {
            for (int x = 0, _x = Table.cols; x < _x; x++)
            {
                if (tiles.Count > 0)
                {
                    GameObject o = tiles[0];
                    Instantiate<GameObject>(o, new Vector3(x, y), Quaternion.identity);
                }   
            }
        }
        
    }

    Vector2 setEndPoint(int startZ)
    {
        Vector2 v = new Vector2();
        int zone;

        do {
            zone = Random.Range(0, 3);
        } while (zone == startZ);
        
        int pos;

        switch (zone)
        {
            case 0: //top
                pos = Random.Range(0, ROWS - 1);
                v.Set(pos, 0);
                break;
            case 1: //Right
                pos = Random.Range(0, COLS - 1);
                v.Set(COLS - 1, pos);
                break;
            case 2: //Down
                pos = Random.Range(0, ROWS - 1);
                v.Set(pos, ROWS - 1);
                break;
            case 3: //top
                pos = Random.Range(0, COLS - 1);
                v.Set(0, pos);
                break;
        }

        return v;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
