using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
    public float speed = 800f;
    public float timeToDeath = 5f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb= GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.forward* speed * Time.deltaTime);
        
        timeToDeath -= Time.deltaTime;

        if(timeToDeath <= 0)
        {
            Destroy(gameObject);
        }
		
	}
}
