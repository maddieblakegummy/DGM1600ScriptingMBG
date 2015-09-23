using UnityEngine;
using System.Collections;

public class ifstatements : MonoBehaviour {
	public float toobright = 60.0f;
	public float lightquality = 90.0f;
	public float toodark = 10.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			LightTest ();

		lightquality -= Time.deltaTime * 8.0f;
	}
	void LightTest ()
	{

		if (lightquality > toobright) 
		{
			Debug.Log("It's Too Bright.");
		}
		else if (lightquality < toodark) 
		{
			Debug.Log("It's Too Dark.");
		} 
		else 
		{
			Debug.Log("It's Perfect Lighting.");
		}
	}
}
