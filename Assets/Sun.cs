using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public int speed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed*Time.deltaTime, 0, 0);
    }
}
