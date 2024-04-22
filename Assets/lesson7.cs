using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson7 : MonoBehaviour
{
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        for(int i=1; i<13; i++)
        {
            
        Vector3 p = new Vector3();
        p.x= i*1.9f-7.5f;
        p.y= Mathf.Cos(i)-2;
        p.z= 0;
        Instantiate(prefab,p,Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
