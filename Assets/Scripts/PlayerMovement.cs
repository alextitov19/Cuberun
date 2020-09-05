using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 500f;

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 200, 500);
        player = new Player();
        player.LoadData();
        for(int i = 0; i < player.perkSlowMoSelected; i++)
        {
            forwardForce  *= 0.9f;
            sidewaysForce  *= 0.9f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        transform.eulerAngles = new Vector3(-90, 45, 0);

        if (Input.GetKey("d") || RightButtonManager.rightButtonPressed == true)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || ButtonManager.leftButtonPressed == true)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
