using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void CreateCharacter()
    {
        SceneManager.LoadScene("AaronsScene");
    }
    public void Families()
    {
        SceneManager.LoadScene("FamiliesScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
