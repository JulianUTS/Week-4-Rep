using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide: MonoBehaviour
{
    
    int i = 3;
    public GameObject Object;
    public Renderer rend;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Object.name + ":" + i);
        rand = Random.Range(200, 251);



    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(Object.name + ":" + i);
        if (i == 100 && Object.tag == "Red")
        {
            Object.SetActive(false);
  

        } else if (i == rand && Object.tag == "Blue")
        {
            // Object.GetComponent<Renderer>().enabled = false;
            Object.GetComponent<Renderer>().enabled = false;

        }
       
            

     
        


    }
}
