using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static float bottomBoarder = -7.0f;
    public static float topBoarder = 7.0f;
    public static float rightBoarder = 12.0f;
    public static float leftBoarder = -12.0f;

    public float timer = 2.0f;

    public static GameManager instance = null;

    public GameObject enemyPrefab;


	// Use this for initialization
	void Start () {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            GameObject enemyInstance = Instantiate(enemyPrefab);
            enemyInstance.transform.position = new Vector3(-11f, Random.Range(-5f, 5f), -3f);

            timer = 2f;
        }

        if (Input.GetKey(KeyCode.Tab)) {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "PlayScene") {
                SceneManager.LoadScene("PlayScene2");
            } else {
                SceneManager.LoadScene("PlayScene");
            }

        }

	}

}