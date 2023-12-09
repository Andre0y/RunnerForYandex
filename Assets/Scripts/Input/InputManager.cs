using System.Runtime.InteropServices;
using UnityEngine;

public static class InputManager
{
    [DllImport("__Internal")] private static extern string getDeviceType();

    public static float GetAxis(string axisName)
    {
        return Input.GetAxis(axisName);
    }

    public static bool IsMoving(string axisName)
    {
        return Input.GetAxis(axisName) != 0;
    }

    public static bool IsLeftMouseButtonDown()
    {
        ////if (getDeviceType() == "mobile")
        ////{
        ////    return true;
        ////}

        if (Input.GetMouseButton(0))
        {
            return true;
        }

        return false;
    }
}
