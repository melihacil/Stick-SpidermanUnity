using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{

    [SerializeField] private Transform shootingPointTransform;
    [SerializeField] private Transform otherHand;
    [SerializeField] private Transform point;
    [SerializeField] private LineRenderer lineRenderer;

    public Transform startPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        float AngleRad = Mathf.Atan2(mouse.y - shootingPointTransform.position.y, mouse.x - shootingPointTransform.position.x);
        // Get Angle in Degrees
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        // Rotate Object
        
        this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, AngleDeg);


        if (Input.GetMouseButtonDown(0))
        {
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0,shootingPointTransform.position);
            lineRenderer.SetPosition(1,mouse);



        }

        //this.transform.position= new Vector3(point.position.x,this.transform.position.y, transform.position.z);
        //transform.position = point.position;
        //otherHand.rotation = this.transform.rotation;
    }
}
