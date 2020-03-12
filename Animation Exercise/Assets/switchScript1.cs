using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class switchScript1 : MonoBehaviour
{
   public KeyCode MyKey;
     public string MyTrigger;
 
     void Update()
     {
         if (Input.GetKey(MyKey))
         {
             GetComponent<Animator>().SetTrigger(MyTrigger);
         }
     }
}
