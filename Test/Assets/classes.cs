using UnityEngine;
using System.Collections;

public class classes : MonoBehaviour {

	public GameObject[] player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectsWithTag ("Player");
		for (int i = 0; i < player.Length; i++)
			Debug.Log ("Player number " + i + " is named" + player [i].name);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
