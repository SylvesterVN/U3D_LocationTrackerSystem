using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityScript.Steps;


/*This script stores the different in Game areaTypes in order to track the players current location.  
 * Assign this script to any object which the player can be located. */
public class LocationData : MonoBehaviour
{
    //Enum storing different areaTypes, simply input the different types of areas to store them
    public enum areaType { areaType1}
    

    public areaType areaLevels;
    
    //This is the name assigned to the object in order to accurately track the players location
    public string RoomName;
    
    //during the start method the object is assigned the correct AreaType and declared name
    private void Start()
    {
        //create additional conditions for more area types
        if (areaLevels == areaType.areaType1)
        {
            this.gameObject.name =  "AT1_" + RoomName;
            
        }
       
            
        //Assigns the objects to the ground layer 
        gameObject.layer = 13;
    }

}
