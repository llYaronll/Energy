using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converteranim : MonoBehaviour
{

    public Material converterM1;
    public GameObject  converter1,converter2,converter3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ConverterPower()
    {
        converter1.GetComponent<Renderer>().material=converterM1;
        converter2.GetComponent<Renderer>().material=converterM1;
        converter3.GetComponent<Renderer>().material=converterM1;
    }
}
