using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{ 
    [SerializeField] Vector3[] pos;
    //[Range(0.1f,3.0f)][SerializeField] delay;
    Vector3 previousLocation = new Vector3(0, 0, 0);
    [SerializeField] TextAsset appData;
    List<Vector3> coordinates = new List<Vector3>();
    private bool isWait = true;
    private int i = 0;
    private int nirmul = 15000;


    // Start is called before the first frame update
    void Start()
    {
        string[] allFile = appData.text.Split(new char[] { '\n' });

        for (int i = 1; i < allFile.Length-1; ++i)
        {
            string[] raw = allFile[i].Split(new char[] { ',' });
            coordinates.Add(new Vector3(float.Parse(raw[2]), float.Parse(raw[3]), float.Parse(raw[4])));
        }
        
        StartCoroutine(StartDelay());
        transform.position = coordinates[0]/nirmul;

        
    }
    
    private void Update()
    {
        //print("aaa");
        if (!isWait)
        {
            Move();
        }

        transform.Rotate(new Vector3(0, 18f, 0) * Time.deltaTime);
    }
 
    private void Move()
    {
        if (i == coordinates.Count - 1 )
        {
           i = 0;
        }
        transform.position = coordinates[i]/nirmul;
        i += 1;
    }
 
    //after 10 seconds, the object moves
    IEnumerator StartDelay()
    {
        isWait = true;//object now waits to move
        yield return new WaitForSeconds(2);
        isWait = false; //object is no longer waiting to move
    }
}
