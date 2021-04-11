using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hittarget : MonoBehaviour
{



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Target"))
        {
            Destroy(collision.gameObject);
        }

    }



        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Bullet"))
        {
             Destroy(other.gameObject);
        }
        }

    

    
}
