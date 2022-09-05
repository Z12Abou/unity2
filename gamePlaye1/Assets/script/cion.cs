using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cion : MonoBehaviour
{
    // Start is called before the first frame update
   public void affecteCoin(GameObject effct)
    {
         Instantiate(effct, transform.position,Quaternion.identity);
        
    }
}
