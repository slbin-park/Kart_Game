using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 180f;

    public ArcadeKart KartController;

    public AudioSource ac;

    public viewcointext vc;

    [System.NonSerialized]
    public int money = 100;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void SetCoinValue(int money)
    {
        this.money = money;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            ac.Play();
            ArcadeKart kart = FindObjectOfType<ArcadeKart>();
            kart.Addmoney(money);
            Destroy(gameObject);
            vc = FindObjectOfType<viewcointext>();
            vc.set_money();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
    }
}
