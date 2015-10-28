using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
    bool isPassable;
    bool isOccupied;
    int x, y;
    int[] position = new int[2];
    // Use this for initialization
    public Tile(int newX, int newY)
    {
        setPosition(newX, newY);
    }
    
    void Start()
    {

    }
	
	// Update is called once per frame
	void Update()
    {
	    
	}

    int[] getPosition()
    {
        position[0] = x;
        position[1] = y;
        return position;
    }

    void setPosition(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public void setIsOccupied()
    {
        isOccupied = !isOccupied;
    }
}
