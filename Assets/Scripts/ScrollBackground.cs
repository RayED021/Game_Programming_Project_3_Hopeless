using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float speed;
    public float newPosX;
    public float posXTrigger;
    public Transform otherMap;
    bool isStuck = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PositionUpdate();
        CheckPosition();
    }

    private void CheckPosition()
    {
        if(transform.position.x <= posXTrigger && !isStuck)
        {
            isStuck = true;
            NewPosition();
            isStuck = false;
        }
    }

    public void NewPosition()
    {
        transform.position = new Vector3(otherMap.position.x + newPosX, transform.position.y, transform.position.z);
    }

    private void PositionUpdate()
    {
        var movement = Time.deltaTime * speed;
        transform.position = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
    }
}
