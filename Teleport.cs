using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : GazeableObject
{
    // Start is called before the first frame update
 public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        if (Player.instance.activeMode == InputMode.TELEPORTSPOT)
        {
            Vector3 destLocation = transform.position;

            destLocation.y = Player.instance.transform.position.y;

            Player.instance.transform.position = destLocation;

        }

    }
}
