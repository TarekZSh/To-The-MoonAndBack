using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HomeButton : MonoBehaviour
{
    [SerializeField] Vector3 startLocation;
    [SerializeField]GameObject image1;
    [SerializeField]GameObject image2;
    [SerializeField]GameObject image3;
    public void setStartLocation()
    {
        GameObject.FindGameObjectWithTag("Image").SetActive(false);
        image1.SetActive(true);
        image2.SetActive(true);
        image3.SetActive(true);
        LiveButton.isOpen = false;
    }
}
