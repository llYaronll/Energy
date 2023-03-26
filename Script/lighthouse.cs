using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighthouse : MonoBehaviour
{
    public GameObject house,house2,lightbase;
   

    // Update is called once per frame
   public void allOn(){
       var houseRander = house.GetComponent<Renderer>();
        houseRander.material.SetColor("_EmissionColor", Color.white);
         var houseRander2 = house2.GetComponent<Renderer>();
        houseRander2.material.SetColor("_EmissionColor", Color.white);
         var baseRander = lightbase.GetComponent<Renderer>();
        baseRander.material.SetColor("_EmissionColor", Color.white);
   }
}
