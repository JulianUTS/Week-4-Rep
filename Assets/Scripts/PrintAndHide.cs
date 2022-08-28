using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide: MonoBehaviour
{

    int i = 3;
    public GameObject Object_name;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Object_name.name + ":" + i);
    
        
    }

    // Update is called once per frame
    void Update()
    {
        i = i + 1;
        Debug.Log(Object_name.name + ":" + i);
    }
}
