using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GhostLoader[] ghostLoaders;

     
    void GhostCollecterOver()
    {
        foreach(GhostLoader ghostLoader in ghostLoaders )
        {
            if(ghostLoader.isCollected == true)
            {
                Debug.Log("Game Over");
            }
        }
    }
    
}
