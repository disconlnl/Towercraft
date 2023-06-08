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
            gameObjectSelf.transform.parent = blockParent;
            distance.breakForce = 0;
            distance.connectedBody = null;

        }
    }


}