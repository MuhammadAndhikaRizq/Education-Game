using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject selectedCharacter;
    public GameObject player;

    private Sprite playerSprite;

    void Start()
    {
        playerSprite = selectedCharacter.GetComponent<SpriteRenderer>().sprite;

        player.GetComponent<SpriteRenderer>().sprite = playerSprite;
    }
}