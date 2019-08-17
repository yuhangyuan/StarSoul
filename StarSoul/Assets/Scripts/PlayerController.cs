using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceSize;
    public Rigidbody MyBody;
    public Transform StarCoreTrans;
    public bool isGround;
    public float mJumpVelocity;
    public float mJumpSpeed;
    public float BasicSpeed;
    public float ActuallySpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z != 0)
        { transform.position = new Vector3(transform.position.x, transform.position.y, 0); }
        MyBody.AddForce((StarCoreTrans.position - transform.position).normalized * forceSize, ForceMode.Force);
        transform.forward = (StarCoreTrans.position - transform.position).normalized;

        PlayerMove();

    }

    private void FixedUpdate()
    {
        //transform.rotation = Quaternion.LookRotation(Vector3.forward, (transform.position - StarCoreTrans.position).normalized);
        if (Input.GetButtonDown("Jump"))
        {
            if (isGround == true)
            {
                //transform.Translate(new Vector3(Input.GetAxis("Horizontal") * distance, 2, Input.GetAxis("Vertical") * distance));
                GetComponent<Rigidbody>().velocity += (transform.position - StarCoreTrans.position).normalized * mJumpVelocity;
                GetComponent<Rigidbody>().AddForce((transform.position - StarCoreTrans.position).normalized * mJumpSpeed);
                isGround = false;
                Debug.Log("I am Pressing Jump");
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Ground")
        {
            isGround = true;
            //Debug.Log("Jump is ready");
        }
    }

    void PlayerMove()
    {
        if (ActuallySpeed < 0) ActuallySpeed = 0;
        //transform.position += (transform.position - StarCoreTrans.position).normalized * Input.GetAxis("Horizontal");

        if (transform.position.x > 0)
        {
            //临时解决旋转bug问题，日后掌握更多四元数知识之后再来调教,镜头也有同样问题
            if (-0.001f < transform.rotation.y && transform.rotation.y < 0.001f) { transform.eulerAngles = new Vector3(transform.rotation.x, -0.5f, transform.rotation.z); }

            transform.position -= transform.up * Input.GetAxis("Horizontal") * Time.deltaTime * BasicSpeed * ActuallySpeed;
        }
        else
        {
            //临时解决旋转bug问题，日后掌握更多四元数知识之后再来调教,镜头也有同样问题
            if (-0.001f < transform.rotation.y && transform.rotation.y < 0.001f) { transform.eulerAngles = new Vector3(transform.rotation.x, 0.5f, transform.rotation.z); }

            transform.position += transform.up * Input.GetAxis("Horizontal") * Time.deltaTime * BasicSpeed * ActuallySpeed;
        }
        //Debug.Log("前方=" + transform.forward + ";上方-" + transform.up + ";右方=" + transform.right + ";世界前方=" + Vector3.forward);
        //Debug.Log(transform.rotation.y);

    }

}
