using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    GameObject panel;
    bool isHere = false;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Text");
        panel.SetActive(false);

    }

    public void setText()
    {
        if(isHere.Equals(false))
        {
            panel.SetActive(true);
            isHere = true;
        }
        else
        {
            panel.SetActive(false);
            isHere = false;
        }
    }
}
