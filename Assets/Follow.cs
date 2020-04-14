using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    [SerializeField]
    private Transform toFollow;
    [SerializeField]
    private Vector3 offset;
    private Quaternion rotation;

    // Update is called once per frame
    void Update()
    {
        transform.position = toFollow.position + offset;
        transform.rotation = toFollow.rotation;
    }
}
