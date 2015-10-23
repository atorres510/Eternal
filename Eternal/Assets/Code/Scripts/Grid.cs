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
        tiles = new Tile[gridwidth,gridheight];
	}
	
	// Update is called once per frame
	void Update()
    {
	    
	}
}
