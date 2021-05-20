using UnityEngine;

public class Coins : MonoBehaviour
{
    public int quant;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            ClickToMove.coins += quant;
            Debug.Log("Coins added: " + quant);
            Destroy(gameObject);
        }
    }
}