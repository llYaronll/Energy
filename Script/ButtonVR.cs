using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    [SerializeField] private float theshold =0.1f;
    [SerializeField] private float deadZone=0.025f;
    public GameObject button;
    public UnityEvent onPressed,onReleased;
   // GameObject presser;
   // AudioSource source;
    private bool _isPressed;
   public Vector3 _startPos;
   public    ConfigurableJoint _joint;
  
   

    // Start is called before the first frame update
    void Start()
    {
        
        _startPos=transform.localPosition;
        _joint=GetComponent<ConfigurableJoint>();
        //source = GetComponent<AudioSource>();
       
    }
    void Update()
    {
       Debug.Log(GetValve() + theshold);
       Debug.Log(GetValve() - theshold);

         if(!_isPressed && GetValve() + theshold >=0.11)
        {
            Pressed();
            Debug.Log("好");
        }
            
        if(!_isPressed && GetValve() - theshold >=-0.09)
        {
            Release();
            Debug.Log("不好");
            
           
        }          
    }

    private float GetValve(){
        //_joint.linearLimit.limit
         var Valve =Vector3.Distance(_startPos,transform.localPosition)/_joint.linearLimit.limit;      
         if( Math.Abs (Valve) < deadZone)
        { 
            Valve=0;
        }
         // Debug.Log(Mathf.Clamp(Valve,-1f,1f));
        return Mathf.Clamp(Valve,-1f,1f);
        
    }

    private void Pressed()
    {
        
        _isPressed=true;
        onPressed.Invoke(); 
        


    }
     private void Release()
    {
        _isPressed=false;
        onReleased.Invoke();
               
    }

    public void change()
    {
        var cubeRenderer = button.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_EmissionColor", Color.black);
    }

  
    
}
