using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadGame()
    {
    SceneManager.LoadScene("SampleScene");
    }   

    public void LoadCredits()
    {
    SceneManager.LoadScene("Credits");
    }

    public void LoadTitleScreen()
    {
    SceneManager.LoadScene("TitleScene");
    }


}
