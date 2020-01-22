using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float jumpforce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMov = this.transform.position.x + speed * Input.GetAxis("Horizontal") * Time.deltaTime;

        this.transform.position = new Vector3(xMov,
            this.transform.position.y,
            this.transform.position.z);
    }
}
