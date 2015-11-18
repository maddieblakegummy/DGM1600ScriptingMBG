using UnityEngine;
using System.Collections;

public class enums : MonoBehaviour {

	enum Direction : short {North = 3, South = 5};

	// Use this for initialization
	void Start () {
		Direction myDirection;
		myDirection = Direction.North;
		myDirection = ReverseDirection (myDirection);
	}
	
	// Update is called once per frame
	void Update () {

	}
	Direction ReverseDirection (Direction dir)
	{
		if (dir == Direction.North)
			dir = Direction.South;
		else if (dir == Direction.South)
			dir = Direction.North;
		return dir;
	}

}
