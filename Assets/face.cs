using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face : MonoBehaviour
{

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
      if(pos.y>= -0.55f)
      {
          speed = -0.1f;
      }
      if(pos.y<= -2.75f)
      {
          speed = 0.1f;
      }
      pos.y += speed;
      transform.position = pos;
    }
}
