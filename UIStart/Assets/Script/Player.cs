using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    float Hor;
    float Ver;
    // Start is called before the first frame update
    void Start()
    {
        Hor = 0;
        Ver = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FixedUpdate()
    {
        Hor = Input.GetAxis("Horizontal");
        Ver = Input.GetAxis("Vertical");

        Vector3 Pos = transform.position;
        Pos.x += Hor * MoveSpeed;
        Pos.z += Ver * MoveSpeed;
        transform.position = Pos;
    }
}
