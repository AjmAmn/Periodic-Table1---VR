using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneContro : MonoBehaviour
{
    // Start is called before the first frame update
    public void HomeScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GroundScene()
    {
        SceneManager.LoadScene("Ground");
    }
    public void MidScene()
    {
        SceneManager.LoadScene("MidAir");
    }
    public void TargetScene()
    {
        SceneManager.LoadScene("Target");
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
