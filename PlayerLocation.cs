using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*This Script will be assigned to the player object and uses a raycast to check the Current Object 
 * they are above and will set the current location to be equal to that object name*/
public class PlayerLocation : MonoBehaviour
{
    private GameObject hit;
    public string currentLocation;
    private Vector3 collision = Vector3.zero;
    public LayerMask LayerMask;

    
    private LocationData locData;


    void Start()
    {
        currentLocation = "NoLocationDataFound";
        
        
        locData = GameObject.FindObjectOfType<LocationData>();

    }

    //update method projects a Raycast pointing downwards to check what the player is standing on
    void Update()
    {
        var ray = new Ray(origin:this.transform.position,direction:-Vector3.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance:100, LayerMask))
        {
            
            collision = hit.point;
            currentLocation = hit.transform.gameObject.name;
           
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(collision, radius: 0.2f);
    }
}
