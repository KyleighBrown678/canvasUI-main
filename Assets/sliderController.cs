using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
    }

    public void sliderRotateX(float rotateAmount)
    {
        transform.rotation = Quaternion.Euler(rotateAmount, 0f, 0f);
    }

    public void sliderRotateY(float rotateAmount)
    {
        transform.rotation = Quaternion.Euler(0f, rotateAmount, 0f);
    }

    public void sliderRotateZ(float rotateAmount)
    {
        transform.rotation = Quaternion.Euler(0f, 0f, rotateAmount);
    }

    public void sliderPositionX(float positionAmount)
    {
        transform.position =  new Vector3(positionAmount, 0f, 0f);
    }

    public void sliderPositionY(float positionAmount)
    {
        transform.position = new Vector3(0f, positionAmount, 0f);
    }

    public void sliderPositionZ(float positionAmount)
    {
        transform.position = new Vector3(0f, 0f, positionAmount);
    }
}
