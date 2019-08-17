using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform PlayerTrans;
    public Transform starCore;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerTrans.position - new Vector3(0, 0, 50f);
        //transform.rotation = Quaternion.LookRotation((transform.position - starCore.position).normalized);
        transform.up = (transform.position - starCore.position + new Vector3(0, 0, 50f)).normalized;
    }
}
