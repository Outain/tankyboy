using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour {
    Transform cube;
    public Transform redCube;
    public Transform blueCube;
    public Transform yellowCube;
    public Transform greenCube;

	// Use this for initialization
	void Start () {

        for(int i=0; i < 5; i++)
        {
            
            
            for (int j = 0; j < 5; j++)
            {
                int cubeNumber = Random.Range(0, 4);
                if (cubeNumber == 0)
                {
                    cube = redCube;
                }

                if (cubeNumber == 1)
                {
                    cube = blueCube;
                }
                if (cubeNumber == 2)
                {
                    cube = yellowCube;
                }
                if (cubeNumber == 3)
                {
                    cube = greenCube;
                }
                Instantiate(cube, new Vector3(i * 1.1F, j*1.1f, 0), Quaternion.identity);
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
