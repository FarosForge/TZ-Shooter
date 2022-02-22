using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : IModel
{
    private Vector2 InputAxis
    {
        get
        {
            return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
    private Vector2 MouseAxis
    {
        get
        {
            return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }
    }

    public Vector3 GetDirection(Transform transform)
    {
        return transform.forward * InputAxis.y + transform.right * InputAxis.x;
    }

    public Vector2 GetRotateDirection()
    {
        return new Vector3(MouseAxis.x, MouseAxis.y);
    }
}
