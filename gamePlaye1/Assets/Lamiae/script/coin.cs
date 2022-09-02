using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public static float scoeCoin=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("plus coin");
            scoeCoin++;
            Destroy(gameObject);

        }
    }
}
