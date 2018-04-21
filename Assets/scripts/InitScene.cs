using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScene : MonoBehaviour {

    const int ROWS = 10;
    const int COLS = 10;
    const float fieldSize = 1F;

    GameObject sceneCamObj;

    // Use this for initialization
    void Start () {
        Screen.SetResolution(1280, 720, true);
        GameObject[][] cubes = new GameObject[ROWS][];

        for (int i = 0; i < ROWS; i++) { cubes[i] = new GameObject[COLS]; }

        for (int i = 0; i < ROWS; i++) {
            for (int j = 0; j < COLS; j++) {
                cubes[i][j] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //cubes[i][j].transform.localScale = new Vector3(fieldSize, fieldSize);
                cubes[i][j].transform.position = new Vector3(-8.39F + i * fieldSize, 4.5F - j * fieldSize);
            }
        }

        cubes[0][0].GetComponent<Renderer>().material.color = Color.red;

        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //cube.transform.position = new Vector3(0, 0, 0);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
