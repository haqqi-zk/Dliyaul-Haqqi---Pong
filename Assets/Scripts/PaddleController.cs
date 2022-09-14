using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D rig;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }
    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST :" + movement);
        rig.velocity = movement;
    }
    public void IncreaseLength()
    {
        transform.localScale =  new Vector3 (transform.localScale.x, 2*transform.localScale.y, transform.localScale.z);
    }
    public void ReturnScale()
    {
        transform.localScale = new Vector3(transform.localScale.x, (transform.localScale.y)/2, transform.localScale.z);
    }
    public void IncreaseSpeed()
    {
        speed *= 2;
    }
    public void ReturnSpeed()
    {
        speed = speed/2;
    }
}
