using UnityEngine;
using UnityEngine.UI;

public class CrosshairModel
{
    public void SetCrosshairColor(Image img)
    {
        if(HitEnemy())
        {
            img.color = Color.yellow;
        }
        else
        {
            img.color = Color.red;
        }
    }

    private bool HitEnemy()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, 1000))
        {
            if(hit.collider.GetComponent<AIView>())
            {
                return true;
            }
        }

        return false;
    }
}
