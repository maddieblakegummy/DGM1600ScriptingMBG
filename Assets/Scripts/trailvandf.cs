using UnityEngine;
using System.Collections;

public class trailvandf : MonoBehaviour {
	int mgint = 8;
	// Use this for initialization
	void Start () {
		mgint = MultiplyByNine (mgint);
		Debug.Log (mgint);
	
	}
	int MultiplyByNine(int number){
		int ret;

		ret = number * 9;
		return ret;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
