using UnityEngine;
using System.Collections;
public class SideWalls : MonoBehaviour
{

    // Verifica colis�es da bola nas paredes
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
    }
}
