using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVector3PropertyInShader : MonoBehaviour
{
    public string PropertyName;
    public Transform pos;
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        material.SetVector(PropertyName, pos.position);
        print("bum");
    }
}
