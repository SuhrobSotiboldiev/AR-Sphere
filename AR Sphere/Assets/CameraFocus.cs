using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vuforia.VuforiaApplication.Instance.OnVuforiaStarted += StartVuforiaFocus;
    }

    public void StartVuforiaFocus()
    {
        Vuforia.VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(Vuforia.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
