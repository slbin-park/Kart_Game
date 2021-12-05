using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;


public class Boaster : MonoBehaviour
{
    public float rotateSpeed = 180f;

    public ArcadeKart KartController;

    public AudioSource ac;

    public viewcointext vc;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            ac.Play();
            ArcadeKart kart = FindObjectOfType<ArcadeKart>();
            Destroy(gameObject);
            kart.Rigidbody.AddForce(kart.transform.forward * 10.0f, ForceMode.VelocityChange);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}