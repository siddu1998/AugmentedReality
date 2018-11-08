using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour {
    public void greetingcard()
    {
        SceneManager.LoadScene("GreetingCardScene");
    }
    public void rotatecube()
    {
        SceneManager.LoadScene("RotateCube");
    }
    public void exitgame()
    {
        Application.Quit();
        Debug.Log("Exit Button Pressed");
    }
}
