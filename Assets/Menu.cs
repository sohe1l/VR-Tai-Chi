using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scene transition numbers will be finalised later. It's hard coded for convenience. 
// Can see scene numbers in File > build settings
public class Menu : MonoBehaviour
{
    public void PlayTraining()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayScored()
    {
        SceneManager.LoadScene(2);
    }
    public void Settings()
    {
        SceneManager.LoadScene(3);
    }
    public void Home()
    {
        SceneManager.LoadScene(0);

    }
    public void EndScreen()
    {
        SceneManager.LoadScene(4);
    }
}
