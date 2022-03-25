using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconClick : MonoBehaviour
{
    public float x;
    public float y;
    private bool touched;
    [SerializeField] private GameObject gameObj;
    [SerializeField] private Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(7, 9);
        touched = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            var wp = Camera.main.ScreenToWorldPoint(touch.position);
            var touchPos = new Vector2(wp.x, wp.y);

            if(collider == Physics2D.OverlapPoint(touchPos))
            {
                gameObj.AddComponent<Rigidbody2D>();
                if(touched == false)
                {
                    StartCoroutine(respawnIcon(x, y));
                    touched = true;
                }
            }
        }
    }

    IEnumerator respawnIcon(float x, float y)
    {
        yield return new WaitForSeconds(4);
        Destroy(this);
        GameObject.Instantiate(gameObj, new Vector3(x, y, 0), Quaternion.identity);
        touched = false;
    }
}
