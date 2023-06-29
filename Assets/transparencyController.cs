using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparencyController : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    [SerializeField] private Renderer myModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlphaSlider(float sliderValue)
    {
        Color color = myModel.material.color;
        color.a = sliderValue;
        myModel.material.color = color;
    }
}
