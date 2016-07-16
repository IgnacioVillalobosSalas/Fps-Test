using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Particle : MonoBehaviour {

    public float attractionForce;
    Rigidbody body;

    void Awake() {

        body = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        body.AddForce(transform.localPosition * -attractionForce);
    }
}
