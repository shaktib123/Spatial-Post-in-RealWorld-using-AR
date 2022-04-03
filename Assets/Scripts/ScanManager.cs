using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnythingWorld;
public class ScanManager : MonoBehaviour
{
    public void StartScan()
    {
        SSTools.ShowMessage("Scanning Started",SSTools.Position.top,SSTools.Time.threeSecond);
        
    }

    public void RecordToText()
    {
        SSTools.ShowMessage("Audio to Text convertion Started", SSTools.Position.top, SSTools.Time.threeSecond);
    }

}
