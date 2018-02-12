using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float moveSpeed = 0.1f;

    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode downKey = KeyCode.DownArrow;
    public KeyCode fireKey = KeyCode.Space;


    public Sprite player1;
    public Sprite player2;

    public float bottomOfScreen = -5f;

    public string sceneToSwitchToOnDeath = "GameOverScene";

    public GameObject firePrefab;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //Choose player
        //if (Input.GetKeyDown(KeyCode.Tab))
        //{
        //    Debug.Log("Changing Player");

        //    if (this.GetComponent<SpriteRenderer>().sprite == player1)
        //    {
        //        this.GetComponent<SpriteRenderer>().sprite = player2;
        //    }
        //    else if (this.GetComponent<SpriteRenderer>().sprite == player2)
        //    {
        //        this.GetComponent<SpriteRenderer>().sprite = player1;
        //    }
        //}

        //Movements
        if (transform.position.x < GameManager.rightBoarder) {
            if (Input.GetKey(rightKey))
            {
                transform.Translate(-moveSpeed, 0, 0);
            }
        }
        if (transform.position.x > GameManager.leftBoarder) {
            if (Input.GetKey(leftKey))
            {
                transform.Translate(moveSpeed, 0, 0);
            }
        }
        if (transform.position.y < GameManager.topBoarder) {
            if (Input.GetKey(upKey))
            {
                transform.Translate(0, moveSpeed, 0);

            }
        }
        if (transform.position.y > GameManager.bottomBoarder){
            if (Input.GetKey(downKey))
            {
                transform.Translate(0, -moveSpeed, 0);
            }
        }

        //Fire
        if (Input.GetKey(fireKey))
        {
            GameObject newFire = Instantiate(firePrefab);
            newFire.transform.position = new Vector3(transform.position.x, transform.position.y - 1.38f, transform.position.z-3);
        }

        //      if (transform.position.y < bottomOfScreen) {
        //          SceneManager.LoadScene(sceneToSwitchToOnDeath);
        //      }
    }
}
