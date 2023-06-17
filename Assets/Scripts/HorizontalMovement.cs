using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    static float t = 0.0f;
    public float distance, speed, timeStart;
    private float originalPosX;
    bool isRotate = false;


    // Start is called before the first frame update
    void Start()
    {
        originalPosX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            new Vector3(originalPosX + Mathf.Sin(t) * distance, transform.position.y, transform.position.z);
        t += speed * Time.deltaTime;
    }
}
