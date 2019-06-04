using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menusc : MonoBehaviour
{

    public void Graj()
    {
        SceneManager.LoadScene(1);
    }

    public void Wyjscie()
    {
        Application.Quit();
    }
}
