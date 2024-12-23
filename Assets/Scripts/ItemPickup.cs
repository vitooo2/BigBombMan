using UnityEngine;

public class ItemPickup : MonoBehaviour
{
      AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public enum ItemType
    {
        ExtraBomb,
        BlastRadius,
        SpeedIncrease,
    }

    public ItemType type;

    private void OnItemPickup(GameObject player)
    {
        switch(type)
        {
            case ItemType.ExtraBomb:
                audioManager.PlaySFX(audioManager.itemPickUp, audioManager.itemPickUpVolume);
                player.GetComponent<BombController>().AddBomb();
                break;

            case ItemType.BlastRadius:
                audioManager.PlaySFX(audioManager.itemPickUp, audioManager.itemPickUpVolume);
                player.GetComponent<BombController>().explosionRadius++;
                break;

            case ItemType.SpeedIncrease:
                audioManager.PlaySFX(audioManager.itemPickUp);
                player.GetComponent<MovementController>().speed++;
                break;

        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            OnItemPickup(other.gameObject);
        }
    }
}
