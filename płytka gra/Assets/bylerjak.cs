using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bylerjak : MonoBehaviour
{
    public GameObject[] okna;
    public int liczbaokien;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < okna.Length; i++)
        {
            if (i == liczbaokien)
            {
                okna[i].gameObject.active = true;
            }
            else
            {
                okna[i].gameObject.active = false;
            }
        }
    }

    public void Przycisk(int lp)
    {
        liczbaokien = lp;
        if (lp == 6)
            SceneManager.LoadScene(0);
    }
}
