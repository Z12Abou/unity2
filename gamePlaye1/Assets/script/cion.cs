using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cion : MonoBehaviour
{
   public void affecteCoin(GameObject effct)
    {
        GameObject effcts= Instantiate(effct,this.transform.position,Quaternion.identity);
        Destroy(effcts, 0.5F);
        
    }
}
