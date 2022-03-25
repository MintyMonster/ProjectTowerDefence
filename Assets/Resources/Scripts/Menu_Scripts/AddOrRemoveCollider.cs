using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AddOrRemoveCollider : MonoBehaviour
{
    [SerializeField] Rigidbody2D mainRb;
    [SerializeField] Collider2D collider1;
    [SerializeField] Collider2D collider2;
    private GameObject[] items;

    private void Start()
    {
        items = Resources.LoadAll<GameObject>("Menu_Prefabs").Cast<GameObject>().ToArray();
        Physics2D.IgnoreLayerCollision(7, 8);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            var wp = Camera.main.ScreenToWorldPoint(touch.position);
            var touchPos = new Vector2(wp.x, wp.y);

            if((collider1 == Physics2D.OverlapPoint(touchPos)) || (collider2 == Physics2D.OverlapPoint(touchPos)))
            {
                Physics2D.IgnoreLayerCollision(7, 8, false);
                mainRb.GetComponent<Rigidbody2D>().WakeUp();
            }
        }
    }
}
