using UnityEngine;
using System.Collections;

public class switchstatements : MonoBehaviour {

	public int intelligence = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Greet ()
	{
		switch (intelligence)
		{
		case 2:
			print ("high intelligence");
			break;
		default:
			print ("incorrect intelligence");
			break;

		}
	}
}
