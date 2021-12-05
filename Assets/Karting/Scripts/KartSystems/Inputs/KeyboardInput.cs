using UnityEngine;
using KartGame.KartSystems;
using TMPro;

namespace KartGame.KartSystems
{

    public class KeyboardInput : BaseInput
    {
        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";
        public TextMeshProUGUI Boost;

        public TextMeshProUGUI Coin;

        public override InputData GenerateInput()
        {
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
                TurnInput = Input.GetAxis("Horizontal")
            };
        }
        void Update()
        {
            ArcadeKart kart = FindObjectOfType<ArcadeKart>();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (kart.boast > 0)
                {
                    kart.delboast(1);
                    Boost.text = string.Format($"\nBoost : {kart.boast}"); ;
                    kart.Rigidbody.AddForce(kart.transform.forward * 10.0f, ForceMode.VelocityChange);
                }

            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (kart.money >= 100)
                {
                    kart.Delmoney(100);
                    Coin.text = string.Format($"\n COIN : {kart.money} ");
                    kart.Rigidbody.AddForce(kart.transform.up * 9.0f, ForceMode.VelocityChange);
                }

            }
        }
    }
}
