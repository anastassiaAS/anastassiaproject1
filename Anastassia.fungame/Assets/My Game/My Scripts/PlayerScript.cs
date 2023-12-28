using UnityEngine;
using System.Collections;


public class PlayerScript : MonoBehaviour
{

    public int coins;
    protected void Start()
    {
        coins = 0;
    }
    protected void OnTriggerEnter(Collider collided)
    {
        if (collided.gameObject.tag == "Coin")
        {
            Destroy(collided.gameObject);
            if (coins == 0)
            {
                HUD.Message("First coin, good job!");
            }
            else
            {
                HUD.Message("Here is your second one!");
            }
            coins++;
            HUD.UpdateCoinCount(coins);
        }

        if (collided.gameObject.name == "Powerup Object 1")
        {
            Destroy(collided.gameObject);
            Abilities.doubleJumpEnabled = true;
            HUD.Message("A double jump is possible!");
        }
    }
}
