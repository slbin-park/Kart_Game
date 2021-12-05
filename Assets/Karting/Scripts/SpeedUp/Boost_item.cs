using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;
using TMPro;

public class Boost_item : MonoBehaviour
{

    public ArcadeKart KartController;

    public TextMeshProUGUI Boost;
    public AudioSource ac;



    [System.NonSerialized]
    public int boost = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void SetCoinValue(int boost)
    {
        this.boost = boost;
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            ac.Play();
            ArcadeKart kart = FindObjectOfType<ArcadeKart>();
            kart.Addbost(boost);
            Destroy(gameObject);
            Boost.text = string.Format($"\nBoost : {kart.boast}"); ;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
