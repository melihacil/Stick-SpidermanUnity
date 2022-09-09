using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappling : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private DistanceJoint2D distanceJoint2D;

    [SerializeField] private Rigidbody2D mousePos;
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float forwardForce;



    private void Awake()
    {
        distanceJoint2D = GetComponent<DistanceJoint2D>();
        playerRb = GetComponent<Rigidbody2D>();
    }




    private void Start()
    {
        distanceJoint2D.enabled = false;
    }



    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            Debug.Log("Shooting");
            mousePos.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Shoot();
        }
        else
            distanceJoint2D.enabled = false;
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(Vector2.right * forwardForce, ForceMode2D.Force);
    }

    private void Shoot()
    {
        distanceJoint2D.enabled = true;
        distanceJoint2D.connectedBody = mousePos;
    }


}
