using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchChecker : MonoBehaviour
{
    public ProfileChanger profileChanger1;
    public ProfileChanger profileChanger2;
    public int bee1;
    public int bee2;

    private void Update() 
    
    {
        bee1 = profileChanger1.currentProfile;  
        bee2 = profileChanger2.currentProfile;  
    }
    
    public void CheckForMatch()
    {
        if(bee1 == bee2)
        {
            Debug.Log("It's a match!");
        }

        if(bee1 != bee2)
        {
            Debug.Log("They'd be terrible together!");
        }
        
    }
}
