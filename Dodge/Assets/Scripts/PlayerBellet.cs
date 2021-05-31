using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBellet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
    public int damage = 30;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            //bullet을 bellet으로 오타남. ㅋㅋ;;
            Bellet bellet = other.GetComponent<Bellet>();

            if (bellet != null)
            {
                Destroy(bellet.gameObject);
            }

            Destroy(gameObject);
        }
        else if (other.tag == "BulletSpawner")
        {
            BulletSpawner spawner = other.GetComponent<BulletSpawner>();

            if (spawner != null)
            {
                spawner.GetDamage(damage);
            }

            Destroy(gameObject);
        }
    }

}
