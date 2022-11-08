using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileChanger : MonoBehaviour
{
    public Image profile;
    public List<Sprite> profileChoices;
    private int currentProfile = 0;

    public void ChangeImageUp()
    {
        currentProfile++;

        if(currentProfile >= profileChoices.Count)
        {
            currentProfile = 0;
        }

        profile.sprite = profileChoices[currentProfile];

    }

    public void ChangeImageDown()
    {
        currentProfile--;

        if(currentProfile < 0)
        {
            currentProfile = profileChoices.Count - 1; 
        }

        profile.sprite = profileChoices[currentProfile];

    }

    
}
