using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
   
    public void DeActivate () {
        gameObject.SetActive(false);
    }
    public void Activate()
    {
        gameObject.SetActive(true);
    }
}
