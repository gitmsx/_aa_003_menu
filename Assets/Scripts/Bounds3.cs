using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        var bounds = GetComponent<MeshFilter>().sharedMesh.bounds;
        print(bounds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
