using UnityEngine;

public static class LayerCollisionManager
{
    /// <summary>
    /// Sets the collision rules between two layers.
    /// </summary>
    /// <param name="layer1">The first layer.</param>
    /// <param name="layer2">The second layer.</param>
    /// <param name="ignore">Whether to ignore collisions between the layers.</param>
    public static void SetLayerCollisionIgnore(string layer1, string layer2, bool ignore)
    {
        int layer1Index = LayerMask.NameToLayer(layer1);
        int layer2Index = LayerMask.NameToLayer(layer2);

        if (layer1Index == -1 || layer2Index == -1)
        {
            Debug.LogError("One of the layers does not exist.");
            return;
        }

        Physics2D.IgnoreLayerCollision(layer1Index, layer2Index, ignore);
    }
}
