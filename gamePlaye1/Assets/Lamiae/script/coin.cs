using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public static float scoreCoin=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreCoin++;
            Destroy(gameObject);

        }
    }
}
