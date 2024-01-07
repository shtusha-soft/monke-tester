using UnityEngine;
public class NoCollision : MonoBehaviour
{
    void Start()
    {
        // Set up layer collisions
        LayerCollisionManager.SetLayerCollisionIgnore("Player", "Player", true);
        // Other initialization code...
    }

    // ... rest of your script ...
}
