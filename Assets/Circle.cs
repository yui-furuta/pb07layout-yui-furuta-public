using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        float r = Random.Range(0.0f,1.0f);
         float g = Random.Range(0.0f,1.0f);
          float b = Random.Range(0.0f,1.0f);
        Color color = new Color(r,g,b,1.0f);
       GetComponent<SpriteRenderer>().color=color;
       speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 pos = transform.position;
      if(pos.y>= -0.8f)
      {
          speed = -0.1f;
      }
      if(pos.y<= -3.0f)
      {
          speed = 0.1f;
      }
      pos.y += speed;
      transform.position = pos;
    }
}
