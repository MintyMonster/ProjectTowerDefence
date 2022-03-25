using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickExplosion
{
    private float explosionForce = 100f;
    private float radius = 100f;

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            Debug.Log("Touched: " + touch.position);
            Collider[] objects = Physics.OverlapSphere(touch.position, radius);
            foreach(Collider c in objects)
            {
                Rigidbody r = c.GetComponent<Rigidbody>();
                if(r != null)
                {
                    r.AddExplosionForce(explosionForce, touch.position, radius);
                }
            }
        }
    }
}
