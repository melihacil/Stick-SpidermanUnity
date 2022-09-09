using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappling : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private DistanceJoint2D distanceJoint2D;

    [SerializeField] private Rigidbody2D mousePos;




    private void Awake()
    {
        distanceJoint2D = GetComponent<DistanceJoint2D>();
    }




    private void Start()
    {
        distanceJoint2D.enabled = false;
    }



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos.position = Input.mousePosition;
            Shoot();
        }
        else
            distanceJoint2D.enabled = false;
    }

    private void Shoot()
    {
        distanceJoint2D.enabled = true;
        distanceJoint2D.connectedBody = mousePos;
    }


}
