using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LiveButton : MonoBehaviour
{
    [SerializeField]GameObject image;
    [SerializeField]GameObject image1;
    [SerializeField]GameObject image2;
    [SerializeField]GameObject image3;
    public static bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {  
        image.SetActive(false);
    }
    public void SetImage()
    {
        if(isOpen.Equals(false))
        {
            image.SetActive(true);
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            isOpen = true;
        }
        else
        {
            image.SetActive(false);
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
            isOpen = false;
        }

    }
}
