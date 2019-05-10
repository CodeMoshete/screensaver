using UnityEngine;
using System.Collections.Generic;

public class Engine : MonoBehaviour
{
    public List<Camera> AvailableCameras;

	void Start () 
	{
        int numDisplays = Mathf.Min(AvailableCameras.Count, Display.displays.Length);

        for (int i = 0; i < numDisplays; ++i)
        {
            Display currentDisplay = Display.displays[i];
            currentDisplay.Activate();
            AssignRandomCamera(i);
        }
	}

    private void AssignRandomCamera(int displayNum)
    {
        int cameraIndex = Random.Range(0, AvailableCameras.Count);
        Camera cam = AvailableCameras[cameraIndex];
        cam.gameObject.SetActive(true);
        AvailableCameras.RemoveAt(cameraIndex);
        cam.targetDisplay = displayNum;
    }
	
	void Update () 
	{
		if (Input.anyKey || Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse Y") > 0)
		{
			Application.Quit ();
		}
	}
}
