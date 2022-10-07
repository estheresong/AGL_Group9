using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFlick : MonoBehaviour
{
    MeshRenderer renderer;

    BoxCollider collider;

    // Start is called before the first frame update
    void Start()
    {
      renderer = GetComponent<MeshRenderer>();
      collider = GetComponent<BoxCollider>();

      InvokeRepeating("camFlash", 1.0f, 1.0f);  
    }

    // Update is called once per frame
    void camFlash()
    {
        renderer.enabled = !renderer.enabled;
        collider.enabled = !collider.enabled;
    }
}
