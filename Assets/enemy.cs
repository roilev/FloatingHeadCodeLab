using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public float moveSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveSpeed, 0, 0);
		
        if (transform.position.x >= GameManager.rightBoarder)
        {
            Destroy(gameObject);
            Debug.Log("destroy enemy");
        }

	}
}
