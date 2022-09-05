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
    public void effectMethod(GameObject effects)
    {
        GameObject effect = Instantiate(effects, this.transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
    }
}
