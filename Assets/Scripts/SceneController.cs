using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject main;
    public GameObject settings;
    public GameObject help;

    public void OnPlay()
    {
        SceneManager.LoadScene(0);
    }
    public void Main()
    {
        main.SetActive(true);
        settings.SetActive(false);
        help.SetActive(false);
    }public void Settings()
    {
        main.SetActive(false);
        settings.SetActive(true);
        help.SetActive(false);
    }
    public void Help()
    {
        main.SetActive(false);
        settings.SetActive(false);
        help.SetActive(true);
    }
}
