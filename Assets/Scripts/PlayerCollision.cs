using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Destructable destructable;

    Player player;

    int multiplier = 1;
    int extraLives = 0;

    private void Awake()
    {
        player = new Player();
        player.LoadData();
        Debug.Log("PLayer successfully inited");
        for(int i = 0; i < player.perk2xSelected; i++)
        {
            multiplier *= 2;
        }
        extraLives = player.perkInvinvibilitySelected;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
            if (collisionInfo.collider.tag == "Obstacle")
             {
                FindObjectOfType<Destructable>().swapToBroken(collisionInfo.collider.gameObject);
                if(extraLives == 0)
                {
                    GetComponent<PlayerMovement>().enabled = false;
                    FindObjectOfType<GameManager>().endGame();
                } else
                {
                    extraLives--;
                }
            }

            if (collisionInfo.collider.tag == "Coin")
            {
                Destroy(collisionInfo.collider.gameObject);
                player.AddCoins(5 * multiplier);
                player.AddXP(5 * multiplier);
            }
    }
   
}
