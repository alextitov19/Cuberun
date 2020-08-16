using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Destructable destructable;
    Player player;

    private void Awake()
    {
        player = new Player();
        player.LoadData();
        Debug.Log("PLayer successfully inited");
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
            if (collisionInfo.collider.tag == "Obstacle")
             {
                FindObjectOfType<Destructable>().swapToBroken(collisionInfo.collider.gameObject);
                GetComponent<PlayerMovement>().enabled = false;
                FindObjectOfType<GameManager>().endGame();
             }

            if (collisionInfo.collider.tag == "Coin")
            {
                Destroy(collisionInfo.collider.gameObject);
                player.AddCoins(1);
                player.AddXP(5);
            }
    }
   
}
