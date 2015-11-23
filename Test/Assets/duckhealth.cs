using UnityEngine;
using System.Collections;

public class duckhealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "KillZone") {
			Destroy (this.gameObject);
		}
	}

}
