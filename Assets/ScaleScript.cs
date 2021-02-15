using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    public GameObject model;
    public float scale;

    [Range(0, 10)]
    public float z = 1;
    [Range(0, 10)]
    public float x = 1;
    [Range(0, 10)]
    public float y = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        model.transform.localScale = new Vector3(x, y, z);
    }
}
