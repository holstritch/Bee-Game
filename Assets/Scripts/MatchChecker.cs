using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchChecker : MonoBehaviour
{
    public ProfileChanger profileChanger1;
    public ProfileChanger profileChanger2;
    public int bee1;
    public int bee2;
    
    public void CheckForMatch() 
    {
        // Check which bee is in each slot
        bee1 = profileChanger1.currentProfile;  
        bee2 = profileChanger2.currentProfile; 
        
        // Check if the bees are a match or not

        if(bee1 == bee2)
        {
            Debug.Log("It's a match!");
            // Remove these bees from the array
            // Add win sound effect
        }

        if(bee1 != bee2)
        {
            Debug.Log("These two aren't a match.");
            // Add incorrect sound effect
        }
        
    }
}
