using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHigher : PowerUpEffect
{
    public override IEnumerator Apply(GameObject player)
    {
        powerActivated = true;
        PlayerScript script = player.GetComponent<PlayerScript>();
        script.flapStrength = 10;
        GetComponent<SpriteRenderer>().enabled = false;

        float elapsed = 0f;
        while (elapsed < powerupDuration)
        {
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }

        script.flapStrength = 7;
        powerActivated = false;
        Destroy(gameObject);
    }
}
