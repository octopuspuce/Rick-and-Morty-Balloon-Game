using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour {

	public void Awake () {
			DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene("Start", LoadSceneMode.Single);
	}

	// Update is called once per frame
	void Update () {

	}

}
