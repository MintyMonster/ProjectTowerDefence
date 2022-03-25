using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconClick : MonoBehaviour
{
    [SerializeField] private GameObject gameObj;
    [SerializeField] private Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(7, 9);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            var wp = Camera.main.ScreenToWorldPoint(touch.position);
            var touchPos = new Vector2(wp.x, wp.y);

            if (collider == Physics2D.OverlapPoint(touchPos))
            {
                gameObj.AddComponent<Rigidbody2D>();
            }
        }
    }

    /*IEnumerator respawnIcon()
    {
        yield return new WaitForSeconds(4);
        GameObject.Instantiate(gameObj, pos, Quaternion.identity);
        Destroy(gameObj.GetComponent<Rigidbody2D>());
        touched = false;
    }*/

    private void OnBecameInvisible()
    {
        Destroy(this);
    }
}
