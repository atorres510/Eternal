using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour
{
    Tile[,] tiles;
    [SerializeField] int gridwidth;
    [SerializeField] int gridheight;
	// Use this for initialization
	void Start()
    {
        //Temporary grid creation
        tiles = new Tile[gridwidth,gridheight];
        for(int i = 0; i < gridwidth; i++)
        {
            for(int n = 0; n < gridheight; n++)
            {
                tiles[i, n] = new Tile(i, n);
            }
        }

        //Temporary unit placement
	}
	
	// Update is called once per frame
	void Update()
    {
	    
	}
}
