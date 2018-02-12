using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {

    public float moveSpeed = 0.1f;
    public float boarder = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -moveSpeed, 0);

        if (transform.position.x > boarder){
            Destroy(gameObject);
        }
	}
}
