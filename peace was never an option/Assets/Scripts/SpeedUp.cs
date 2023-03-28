using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : PowerUpEffect
{
    public override IEnumerator Apply(GameObject player)
    {
        powerActivated = true;
        float currentTimeScale = Time.timeScale;
        Time.timeScale *= 1.1f;
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), true);
        GetComponent<SpriteRenderer>().enabled = false;

        float elapsed = 0f;
        while (elapsed < powerupDuration)
        {
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }

        Time.timeScale = currentTimeScale;
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), false);
        powerActivated = false;
        Destroy(gameObject);
    }
}
