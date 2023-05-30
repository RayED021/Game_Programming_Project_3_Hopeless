using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VerticalMovement : MonoBehaviour
{
    static float t = 0.0f;
    public float distance, speed, timeStart;
    private float originalPosY;
    bool isRotate = false;


    // Start is called before the first frame update
    void Start()
     {
        originalPosY = transform.position.y;
     }

        // Update is called once per frame
     void Update()
     {
        transform.position =
            new Vector3(transform.position.x, originalPosY + Mathf.Sin(t) * distance, transform.position.z);
            t+= speed * Time.deltaTime;
     }
}

