using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LocationTracker : MonoBehaviour
{
    
    /*assign this script to a Game Manager and this sctipt will create a list of all the
     * available locations in the game by searching for all the objects with the LocationData sctipt.*/


    public LocationData[] location;
    
    void Start()
    {
        location = GameObject.FindObjectsOfType<LocationData>();

    }

 

}
   
