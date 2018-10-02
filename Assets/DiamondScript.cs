using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color NewColor;
    public Transform other;
    [Range(-720,720)]
    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        rend.color = NewColor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new Vector3(3, 2, other.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }


    }
}
