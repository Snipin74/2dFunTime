using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowFish : MonoBehaviour {

    public Transform target1;

    [SerializeField] public float speed;

    public Collider coll;


    public bool PhysicsGravity { get; private set; }

    // Use this for initialization
    void Start() {

        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
    }
    // Update is called once per frame
    void Update() {

        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target1.position, step);

    }

}
/////josh fluctuate the fishes gravity scale to simulate jumping
