using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObstacle : PowerUpEffect
{
    public override IEnumerator Apply(GameObject player)
    {
        powerActivated = true;

        // disable collision with obstacle layer
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), true);
        GetComponent<SpriteRenderer>().enabled = false;

        float elapsed = 0f;
        while (elapsed < powerupDuration)
        {
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }

        // reset collision with obstacle layer
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), false);

        powerActivated = false;
        Destroy(gameObject);
    }
}
