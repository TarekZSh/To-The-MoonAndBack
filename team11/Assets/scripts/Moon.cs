using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{ 
    [SerializeField] Vector3[] pos;
    //[Range(0.1f,3.0f)][SerializeField] delay;
    Vector3 previousLocation = new Vector3(0, 0, 0);
    [SerializeField] TextAsset appData;
    List<Vector3> coordinates = new List<Vector3>();
    private bool isWait = true;
    private int i = 0;
    private int nirmul = 100000;


    // Start is called before the first frame update
    void Start()
    {
        string[] allFile = appData.text.Split(new char[] { '\n' });

        for (int i = 1; i < allFile.Length-1; ++i)
        {
            string[] raw = allFile[i].Split(new char[] { ',' });
            coordinates.Add(new Vector3(float.Parse(raw[2])/nirmul+ 4.35f, float.Parse(raw[3])/nirmul+1.0f, float.Parse(raw[4])/nirmul+ 0.0f));
        }
        
        StartCoroutine(StartDelay());
        transform.position = coordinates[0];
    }
    
    private void Update()
    {
        //print("aaa");
        if (!isWait)
        {
            Move();
        }
    }
 
    private void Move()
    {
        if (i == (coordinates.Count - 1 ))
        {
            StartCoroutine(StartDelay());
           i = 0;
        }
        transform.position = coordinates[i];
        i += 1;
    }
 
    //after 10 seconds, the object moves
    IEnumerator StartDelay()
    {
        isWait = true;//object now waits to move
        yield return new WaitForSeconds(3);
        isWait = false; //object is no longer waiting to move
    }
}
