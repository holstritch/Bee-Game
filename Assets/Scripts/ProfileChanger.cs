using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileChanger : MonoBehaviour
{
    public Image profile;
    public List<Sprite> profileChoices;
    //public int currentProfile = 0;
    public int randomProfile;
    public GameObject winText;


    public void ChangeToRandomProfile()
    {
        randomProfile = Random.Range (0, profileChoices.Count);
        profile.sprite = profileChoices[randomProfile];
    }
    
    /*
    public void ChangeImageUp() // Go to next profile image
    {
        currentProfile++;

        if(currentProfile >= profileChoices.Count) // Reset to first image if you reach end of list
        {
            currentProfile = 0;
        }

        profile.sprite = profileChoices[currentProfile];

    }

    public void ChangeImageDown() // Go to previous profile image
    {
        currentProfile--;

        if(currentProfile < 0) // Reset to final image if you reach start of list
        {
            currentProfile = profileChoices.Count - 1; 
        }

        profile.sprite = profileChoices[currentProfile];

    }
    */
    
    public void RemoveCurrentProfile()
    {
        // Remove this profile from the list
        profileChoices.RemoveAt(randomProfile);
        
        // Move automatically to another profile after removing
        profile.sprite = profileChoices[randomProfile];
    }

    public void WinChecker()
    {
        if (profileChoices.Count == 1)
        {
            Debug.Log("These are the last two profiles, you win");
            winText.SetActive(true);
        }
    }

}
