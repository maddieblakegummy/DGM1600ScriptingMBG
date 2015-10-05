using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {
	int cupsinthesink = 4;
	int numenemies = 3;
	// Use this for initialization
	void Start () {
	
	while (cupsinthesink > 0) {
			Debug.Log ("I've washed a cup!");
			cupsinthesink--;
		}
	
		bool shouldcontinue = false;
		do {
			print ("should continue");
		} while (shouldcontinue == true);

		for (int i=0; i < numenemies; i++) {
			Debug.Log ("I've created enemy number: " + i);
		}

		string[] strings = new string[3];
		strings [0] = "first string";
		strings [1] = "second string";
		strings [2] = "third string";
		foreach (string item in strings) {
			print (item);
		}

	    

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
