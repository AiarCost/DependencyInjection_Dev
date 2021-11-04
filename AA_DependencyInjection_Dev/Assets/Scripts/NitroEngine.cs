using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroEngine : IEngine
{

    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine Started");
    }

    private void OpenNitroValve()
    {
        Debug.Log("The nitro valve is open");
    }
}
