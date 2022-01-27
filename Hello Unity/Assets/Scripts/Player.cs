using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20.0f;

    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null) {
            rb = GetComponent<Rigidbody>();
        }

        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randDir = Random.onUnitSphere * speed;
        rb.AddForce(new Vector3(randDir.x, 0, randDir.z));
    }

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "Obstacle") {    
            MeshRenderer other = collision.gameObject.GetComponent<MeshRenderer>();

            meshRenderer.material.color = other.material.color;
        }
    }

    private void OnCollisionStay(Collision other) {
        
    }

    private void OnCollisionExit(Collision other) {
        
    }

    private void OnTriggerEnter(Collider other) {
        
    }

    private void OnTriggerStay(Collider other) {
        
    }

    private void OnTriggerExit(Collider other) {
        
    }
}
