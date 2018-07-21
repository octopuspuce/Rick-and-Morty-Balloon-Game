using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Transform Balloon;

	// Initializes the player's score to 0
	private int balloonsInstantiated = 0;
	private int score = 0;
	// Player begins with five lives
	private int life = 5;
	private int waitTime = 1;

	// Use this for initialization
	void Start () {
		// Loop background muisc
		StartCoroutine(Spawn1());

	}

	// Update is called once per frame
	void Update () {
	}

	public void BalloonPopped () {
		score++;
	}

    IEnumerator Spawn1()
    {
        while (life > 0)
        {
            yield return new WaitForSeconds(waitTime);
            // Randomize the spawn locations and balloon types
            Instantiate(Balloon, new Vector3(Random.Range(-2.25F,2.25F), -5.5F, 0F), Quaternion.identity);
            balloonsInstantiated++;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        life--;
        Debug.Log(life);
    }
}
