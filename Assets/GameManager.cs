using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class GameManager : MonoBehaviour
{
    public CinemachineVirtualCamera topDown;
    public CinemachineVirtualCamera earthSpot;
    private int times = 0;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("f")) {
            if (topDown.Priority > earthSpot.Priority)
            {
                if (times > 1)
                {
                    earthSpot.Priority += 2;
                }
                times++;
            }
            else {
                topDown.Priority += 2;
            }
        }
    }
}
