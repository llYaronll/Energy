using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlanimation : MonoBehaviour
{
    public Animator m_Animator;
    public GameObject btn_power,btn_dcpower,btn_acpower;
   
    public void Start()
    { 
        m_Animator = gameObject.GetComponent<Animator>();
        
      
    }

    public void Power()
    {
        m_Animator.SetBool("Power", true);
        StartCoroutine (LightPowerButton());
    }
    public void DCPower()
    {
        m_Animator.SetBool("DCPower", true);
         StartCoroutine (LightDCPowerButton());
        
    }
    public void ACPower()
    {
        m_Animator.SetBool("ACPower", true);
         StartCoroutine (LightACPowerButton());
    }

    IEnumerator LightPowerButton()
    {
        yield return new WaitForSeconds(5);
        
        var powerButton = btn_power.GetComponent<Renderer>();
        powerButton.material.SetColor("_EmissionColor", Color.white);

        
    }
    IEnumerator LightDCPowerButton()
    {
        yield return new WaitForSeconds(5);
        
        var dcButton = btn_dcpower.GetComponent<Renderer>();
        dcButton.material.SetColor("_EmissionColor", Color.white);
        
    }
     IEnumerator LightACPowerButton()
    {
        yield return new WaitForSeconds(5);
        
        var acButton = btn_acpower.GetComponent<Renderer>();
        acButton.material.SetColor("_EmissionColor", Color.white);
        
    }
  
}
