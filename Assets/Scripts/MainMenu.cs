using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void CreateCharacter()
    {
        SceneManager.LoadScene("AaronsScene");
    }
    public void Families()
    {
        SceneManager.LoadScene("AaronsScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
