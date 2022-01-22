using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private float speed = 100.0f;
    private float cubeScale = 5.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        transform.Rotate(Vector3.right * Input.GetAxis("Vertical") * Time.deltaTime * speed);
        var scale = transform.localScale;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale + new Vector3(scale.x * cubeScale * Time.deltaTime, scale.y * cubeScale * Time.deltaTime, scale.z * cubeScale * Time.deltaTime);
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale = transform.localScale - new Vector3(scale.x * cubeScale * Time.deltaTime, scale.y * cubeScale * Time.deltaTime, scale.z * cubeScale * Time.deltaTime);
       }
       
    }
}
