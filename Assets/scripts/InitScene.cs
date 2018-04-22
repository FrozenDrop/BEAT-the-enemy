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
	
	// Update is called once per frame
	void Update () {
		
	}
}
