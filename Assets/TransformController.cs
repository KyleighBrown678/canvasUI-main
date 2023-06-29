using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
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

    public void RotateX(float rotateAmount)
    {
        transform.Rotate(rotateAmount, 0f, 0f);
    }

    public void RotateY(float rotateAmount)
    {
        transform.Rotate(0f, rotateAmount, 0f);
    }

    public void RotateZ(float rotateAmount)
    {
        transform.Rotate(0f, 0f, rotateAmount);
    }

    public void PositionX(float positionAmount)
    {
        transform.Translate(positionAmount, 0f, 0f);
    }

    public void PositionY(float positionAmount)
    {
        transform.Translate(0f, positionAmount, 0f);
    }

    public void PositionZ(float positionAmount)
    {
        transform.Translate(0f, 0f, positionAmount);
    }
}
