
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GiveForce : MonoBehaviour
{
    DistanceJoint2D distance;

    [SerializeField] private GameObject gameObjectSelf;
    void Start()
    {
      distance = GetComponent<DistanceJoint2D>();
    }

    
    void Update()
    {
        DropBlock();
    }

    void DropBlock()
    {
        if (Input.GetKey(("w"))&&gameObjectSelf.GetComponent<DistanceJoint2D>()!=null)
        {
            Transform blockParent = GameObject.Find("Floors").transform;
            Vector3 vector3;
            gameObjectSelf.transform.parent = blockParent;
            vector3 = gameObjectSelf.transform.position;
            vector3.z = -3;
            gameObjectSelf.transform.position = vector3;
            distance.breakForce = 0;
            distance.connectedBody = null;
            
        }
    }

    
}
