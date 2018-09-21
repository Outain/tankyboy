using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmove : MonoBehaviour {
    
    public float speed=1f;
    public float turningSpeed = 20f;
    public Transform bullet;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start () {

        //rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * turningSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        }

    }
}
