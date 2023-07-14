using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cubeMove : MonoBehaviour
{
    public float offset = 0.001f, speed = 5.0f;
    private int dir = 1;
    public float finPosition = 2.0f;
    private MeshRenderer meshRenderer;

    public float bump = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,70 * Time.deltaTime,0);

        if ((transform.position.y >= finPosition && dir != -1 )|| (transform.position.y <= -finPosition && dir != 1))
        {
            dir = -dir;
        }
        transform.Translate(0,((speed * Time.deltaTime * Mathf.Abs(finPosition - Mathf.Abs(transform.position.y))) + offset) * dir,0);
        transform.localScale = new Vector3(finPosition - Mathf.Abs(transform.position.y) - finPosition,bump * (finPosition - Mathf.Abs(transform.position.y)),finPosition - Mathf.Abs(transform.position.y) - finPosition);
    }
}
