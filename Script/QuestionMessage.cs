using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMessage : MonoBehaviour
{
    public GameObject q1, q2, q3,s,m;
    // Start is called before the first frame update

    public void Q1()
    {
        q1.SetActive(true);
       
        //m.SetActive(false);
    }

    public void Q2()
    {
        q1.SetActive(false);
        q2.SetActive(true);
    }
    public void Q3()
    {
        q2.SetActive(false);
        q3.SetActive(true);
       
    }

    
    public void success()
    {
        q3.SetActive(false);
      //  s.SetActive(true);
    }

//   public void think()
//   {
//       q1.SetActive(false);
//       q2.SetActive(false);
//       q3.SetActive(false);
//       txt_5.SetActive(true);
//   }
}
