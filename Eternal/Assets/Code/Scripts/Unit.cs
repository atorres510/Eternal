using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
    //Units will hold all of the stats of a character.
    Tile currentLocation;
	// Use this for initialization
	void Start()
    {
	    
	}
	
	// Update is called once per frame
	void Update()
    {
	    
	}

    void Attack(Unit target)
    {
        
    }

    void Move()
    {
        //Set your current location to no longer be occupied.
        currentLocation.setIsOccupied();
        //Move

        //Set your current location to be occupied.
        currentLocation.setIsOccupied();
    }
}
