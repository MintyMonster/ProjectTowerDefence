using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOrRemoveCollider : MonoBehaviour
{
    [SerializeField] Rigidbody2D mainRb;
    [SerializeField] Collider2D collider1;
    [SerializeField] Collider2D collider2;

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            var wp = Camera.main.ScreenToWorldPoint(touch.position);
            var touchPos = new Vector2(wp.x, wp.y);

            if((collider1 == Physics2D.OverlapPoint(touchPos)) || (collider2 == Physics2D.OverlapPoint(touchPos)))
            {
                Debug.Log("Hit");
            }
        }
    }
}
