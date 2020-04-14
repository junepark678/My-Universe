using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-100*Time.deltaTime, 0, 0);
    }
}
