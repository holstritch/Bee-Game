using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchChecker : MonoBehaviour
{
    public ProfileChanger profileChanger1;
    public ProfileChanger profileChanger2;
    public int bee1;
    public int bee2;

    private void Update() // Check which bee is in each slot
    
    {
        bee1 = profileChanger1.currentProfile;  
        bee2 = profileChanger2.currentProfile;  
    }
    
    public void CheckForMatch() 
    {
        if(bee1 == 0 && bee2 == 1)
        {
            Debug.Log("They'll love buzzing about together.");
        }

        if(bee1 == 1 && bee2 == 2)
        {
            Debug.Log("They'll bee happy travelling together!");
        }

        if(bee1 == 2 && bee2 == 0)
        {
            Debug.Log("Lots of laughs for these bees!");
        }

        else
        {
            Debug.Log("These two aren't a match.");
        }
        
    }
}
