using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ViewModel : MonoBehaviour
{
    public float speed = 10f;
    public GameObject obj;

    public void Slider_Change(float newSpeed)
    {
        //Vector3 pos = obj.transform.position;
        //pos.x = newVal;
        //obj.transform.position = pos;
        speed = newSpeed;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
