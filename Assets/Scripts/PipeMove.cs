using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    private Rigidbody2D pipe;
    public float speed;
    private Vector3 pos;
    // Start is called before the first frame update

    private void Awake()
    {
        pipe = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pipe.velocity = new Vector2(speed , pipe.velocity.y);

        pos = transform.position;
        if(pos.x < -13)
        {
            Destroy(gameObject);
        }
    }
}
