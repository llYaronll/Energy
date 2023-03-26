using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    //�Ӷ��O
    public GameObject mirror1,mirror2,mirror3;
    // public int mir;
    public controlanimation controlanimation;
    public Animation mir1,mir2,mir3, mirobject;
    public Converteranim conver;
    //public Vector3 _startPos;

   // public float mirrorcontrol=0f,mirrorchange=0f;
  //  public bool isMirror = false;
//   public void Tomove()
//   {
//       isMirror = true;
//   }
//   public void Done()
//   {
//       isMirror = false;
//   }


    // Update is called once per frame
    //   void Update()
     //   {
     //   if (isMirror == true)
       // {
     //       mirrorchange = mirror.GetComponent<Transform>().localEulerAngles.z;
     //       mirrorcontrol = GetComponent<Transform>().localEulerAngles.z;
     //       mirror.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, mirrorcontrol));
     //   if(mirrorcontrol>=80&& mirrorcontrol <= 90)
     //   {
     //       mir = 30;
     //   }
       // }
      // }
      
    public void touchmirror()
    {
        mir1.Play();
        mir2.Play();
        mir3.Play();
        mirobject.Play();
        StartCoroutine("animPower");
        //transform.localPosition=_startPos;
    }
    IEnumerator animPower()
     {
      yield return new WaitForSeconds (1.0f);
     controlanimation.Power();
      conver.ConverterPower();
    }

}
