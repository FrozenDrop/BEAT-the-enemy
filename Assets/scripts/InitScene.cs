using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScene : MonoBehaviour {

    const int ROWS = 10;
    const int COLS = 10;
    const float fieldSize = 1F;

    GameObject sceneCamObj;
    GameObject[][] cubes;

    // Use this for initialization
    void Start () {
        Screen.SetResolution(1280, 720, true);
        cubes = new GameObject[ROWS][];

        for (int i = 0; i < ROWS; i++) { cubes[i] = new GameObject[COLS]; }

        for (int i = 0; i < ROWS; i++) {
            for (int j = 0; j < COLS; j++) {
                cubes[i][j] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //cubes[i][j].transform.localScale = new Vector3(fieldSize, fieldSize);
                cubes[i][j].transform.position = new Vector3(-8.39F + i * fieldSize, 4.5F - j * fieldSize);
            }
        }

        //cubes[0][0].GetComponent<Renderer>().material.color = Color.red;
        genPath();
    }

    void genPath() {
        //Set Start
        Vector3 sPos = setStartPoint();
        cubes[(int)sPos.x][(int)sPos.y].GetComponent<Renderer>().material.color = Color.red;
        //Set Castle
        Vector2 fPos = setEndPoint((int)sPos.z);
        cubes[(int)fPos.x][(int)fPos.y].GetComponent<Renderer>().material.color = Color.green;
        //GEN PATH
    }

    Vector3 setStartPoint() {
        Vector3 v = new Vector3();
        Random r = new Random();
        int zone = Random.Range(0, 3);
        int pos;

        switch (zone) {
            case 0: //top
                pos = Random.Range(0, ROWS - 1);
                v.Set(pos, 0, zone);
                break;
            case 1: //Right
                pos = Random.Range(0, COLS - 1);
                v.Set(COLS - 1, pos, zone);
                break;
            case 2: //Down
                pos = Random.Range(0, ROWS - 1);
                v.Set(pos, ROWS - 1, zone);
                break;
            case 3: //top
                pos = Random.Range(0, COLS - 1);
                v.Set(0, pos, zone);
                break;
        }

        return v;
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
