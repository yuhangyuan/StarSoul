using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerView : MonoBehaviour
{
    public int ViewDeep = 2;
    int ViewRate;
    float R;
    // Use this for initialization
    void Start()
    {
        ViewRate = ViewDeep;
    }

    void Update()
    {
        RaycastHit hit01;
        Debug.DrawRay(transform.position, Vector3.up * 5.0f, Color.red, .02f);
        Debug.DrawRay(transform.position, Vector3.down * 5.0f, Color.green, .02f);
        Debug.DrawRay(transform.position, Vector3.left * 5.0f, Color.blue, .02f);
        Debug.DrawRay(transform.position, Vector3.right * 5.0f, Color.yellow, .02f);

        bool ray = Physics.Raycast(transform.position, Vector3.down, out hit01, 5);




    }
}
