using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] public Vector3 direction;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * direction * speed + GetComponent<Rigidbody>().velocity.y * Vector3.up;
    }
    public void jump()
    {
        if (isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
