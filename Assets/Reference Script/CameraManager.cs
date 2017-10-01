using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    // Use this for initialization
    public Camera[] cams;
    
    public void CamOneMove()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamTwoMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamThreeMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamFourMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = true;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamFiveMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = true;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamSixMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = true;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamSevenMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = true;
        cams[7].enabled = false;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamEightMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = true;
        cams[8].enabled = false;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }
    public void CamInfoMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;
        cams[8].enabled = true;
        cams[9].enabled = false;
        cams[10].enabled = false;
        cams[11].enabled = false;
        cams[12].enabled = false;
    }

}
	
