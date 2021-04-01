using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class open : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    private bool opening = false;
    private float startingPos;
    void Start() {
        startingPos = transform.rotation.y;
    }
    void Update()
    {

        // Spin the object around the target at 20 degrees/second.
        Debug.Log("transform.rotatio.y = " + transform.rotation.y);
        if (transform.rotation.y < 0.88 && opening)
        {
            transform.RotateAround(target.transform.position, Vector3.up, 100 * Time.deltaTime);
        }else if (transform.rotation.y >= startingPos && opening == false)
        {
            transform.RotateAround(target.transform.position, Vector3.up, -100 * Time.deltaTime);
        }



    }

    public void openMicrowave() {
        opening = true;
    }

    public void closeMicrowave() {
        opening = false;
    }
}
