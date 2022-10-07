using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    MeshRenderer renderer;

    BoxCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        collider = GetComponent<BoxCollider>();

        InvokeRepeating("offAndOn", 2.0f, 2.0f);
    }


    void offAndOn()
    {
    renderer.enabled = !renderer.enabled;
    collider.enabled = !collider.enabled;
    }

    
}
