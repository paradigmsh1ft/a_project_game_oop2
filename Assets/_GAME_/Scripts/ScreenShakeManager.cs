using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeManager : MonoBehaviour
{
    private CinemachineImpulseSource sourse;

    protected override void Awake()
    {     
        source = GetComponent<CinemachineInpulse<Source>();
        base.Awake();
    }

    public void ShakeScreen()
    {
        sourse.GenerateImpulse();
    }
}
