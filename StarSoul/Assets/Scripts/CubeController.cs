using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    float BlockViewTime = 2;
    void Update()
    {
        if (gameObject.layer != 0)
        {
            BlockViewTime -= Time.deltaTime;
            if (BlockViewTime < 0)
            {
                gameObject.layer = 0;
                BlockViewTime = 2;
            }
        }

    }
}
