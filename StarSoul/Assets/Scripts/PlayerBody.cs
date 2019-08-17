using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{

    public Transform BodyUp;
    public Transform BodyDown;
    public Transform BodyLeft;
    public Transform BodyRight;
    public Transform BodyForward;
    public Transform BodyBack;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //身体朝向控制
        if (transform.position.x > 0)
        {
            //在世界右边的时候向右移动
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.LookAt(BodyLeft);
            }
            //在世界右边的时候向左移动
            else if (Input.GetAxis("Horizontal") < 0)
            {
                transform.LookAt(BodyRight);
            }
        }
        else
        {
            //在世界左边的时候向右移动
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.LookAt(BodyRight);
            }
            //在世界左边的时候向左移动
            else if (Input.GetAxis("Horizontal") < 0)
            {
                transform.LookAt(BodyLeft);
            }
        }
    }
}
