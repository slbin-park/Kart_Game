using KartGame.KartSystems;
using TMPro;
using UnityEngine;

public class viewcointext : MonoBehaviour
{
    public TextMeshProUGUI Coin;

    public bool AutoFindKart = true;

    public ArcadeKart KartController;

    void Start()
    {
        if (AutoFindKart)
        {
            ArcadeKart kart = FindObjectOfType<ArcadeKart>();
            KartController = kart;
            Coin.text = string.Format("\n COIN : 0");
        }

        if (!KartController)
        {
            gameObject.SetActive(false);
        }
    }

    public void set_money()
    {
        float money = KartController.money;
        Coin.text = string.Format($"\n COIN : {money} ");
    }
}
