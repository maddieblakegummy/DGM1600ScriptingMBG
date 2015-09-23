using UnityEngine;
using System.Collections;

public class ifstatements2 : MonoBehaviour {
	public float TooBright = 60.0f;
	public float LightQuality = 90.0f;
	public float TooDark = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			LightTest ();
		LightQuality -= Time.deltaTime * 8.0f;
	}
	void LightTest ()
	{
		if (LightQuality > TooBright) {
			Debug.Log ("It's Too Bright");
		} else if (LightQuality < TooDark) {
			Debug.Log ("It's Too Dark");
		} else {
			Debug.Log ("It's Perfect Lighting");
		}
	
	}
}
