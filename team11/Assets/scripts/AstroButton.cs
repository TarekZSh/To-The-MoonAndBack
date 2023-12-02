using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AstroButton : MonoBehaviour
{
    [SerializeField]GameObject astro;
    void Start()
    {
        astro.SetActive(false);
    }
    public void SetAstro()
    {
        astro.SetActive(true);
    }
}
