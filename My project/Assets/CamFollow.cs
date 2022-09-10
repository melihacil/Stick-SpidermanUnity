using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    [SerializeField]private Transform player = null;


    private Vector3 offset;

    private float offsetz;
    // Start is called before the first frame update
    void Start()
    {
        offsetz = transform.position.z - player.position.z;
    }

    // Late update is called after updates are complete
    //Meaning player has completed its movement 
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x,0,offsetz), Time.deltaTime * 3);
    }
}
