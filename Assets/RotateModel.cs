using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotateModel : MonoBehaviour
{
    public float speed = 10f;
    public GameObject obj;
    public GameObject obj2;
    public GameObject curr;

    [Range(0, 10)]
    public float z = 1;
    [Range(0, 10)]
    public float x = 1;
    [Range(0, 10)]
    public float y = .2f;


    public void Slider_Change(float newSpeed)
    {
        speed = newSpeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(true);
        curr = obj;
        obj2.SetActive(false);
        curr.transform.Rotate(0, speed * Time.deltaTime, 0);
        curr.transform.localScale = new Vector3(x, y, z);

    }

    // Update is called once per frame
    void Update()
    {
        //curr.transform.Rotate(0, speed * Time.deltaTime, 0);
        //curr.transform.localScale = new Vector3(x, y, z);
        if (Input.GetKeyDown(KeyCode.S))
        {
            obj.SetActive(false);
            y = 1;
            obj2.SetActive(true);
            curr = obj2;
        }
        curr.transform.Rotate(0, speed * Time.deltaTime, 0);
        curr.transform.localScale = new Vector3(x, y, z);



    }
}
