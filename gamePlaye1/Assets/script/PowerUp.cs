using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] GameObject EffecteUP;
    [SerializeField] GameObject EffectePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject Effect = Instantiate(EffecteUP, transform.position, transform.rotation);
            Destroy(Effect, 2);
            Destroy(gameObject);
            other.gameObject.GetComponent<move>().SupparPaoire(EffectePlayer);
        }
    }
    void powerUp(GameObject player)
    {
        
    }
}
