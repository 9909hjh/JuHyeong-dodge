using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    int healAmount = 20;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0f, 15f * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
                playerController.GetHeal(healAmount);
            }

            Destroy(gameObject);
        }
    }
}
