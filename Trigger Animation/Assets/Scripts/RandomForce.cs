using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    public float min = 20000f;
    public float max = 20000f;
    GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        block = this.gameObject;
        rb = GetComponent<Rigidbody>();
        force = Random.Range(min, max);
        rb.AddExplosionForce(force, block.transform.position, force);
    }
}