using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    private int track = 0;
    private Outline[] outlines;

    public void Start ()
    {
        outlines = GetComponentsInChildren<Outline>();
		Debug.Log ("in menu script "+outlines.Length);
		if (outlines.Length > 0) 
		{
			outlines [0].effectColor = new Color (0, 0, 0);
		}
    }

	public void ControlMenu()
	{
		SceneManager.LoadScene ("ControlMenu");
	}

	public void MainMenu()
	{
		Debug.Log ("go to main menu");
		SceneManager.LoadScene ("MenuScene");
	}

    public void StartDrivingMode()
    {
        if (track == 0) {
            SceneManager.LoadScene("LakeTrackTraining");
        } else if (track == 1){
            SceneManager.LoadScene("JungleTrackTraining");
        } else if (track == 2){
            SceneManager.LoadScene("MountainTrackTraining");
        }

    }

    public void StartAutonomousMode()
    {
        if (track == 0) {
            SceneManager.LoadScene("LakeTrackAutonomous");
        } else if (track == 1){
            SceneManager.LoadScene("JungleTrackAutonomous");
        } else if (track == 2){
            SceneManager.LoadScene("MountainTrackAutonomous");
        }
    }

    public void SetLakeTrack()
    {

        track = 0;
        outlines [0].effectColor = new Color (0, 0, 0);
        outlines [1].effectColor = new Color (255, 255, 255);
        outlines [2].effectColor = new Color (255, 255, 255);
        
    }

    public void SetMountainTrack()
    {
        track = 1;
        outlines [1].effectColor = new Color (0, 0, 0);
        outlines [0].effectColor = new Color (255, 255, 255);
        outlines [2].effectColor = new Color (255, 255, 255);
    }

    public void SetAkinaTrack()
    {
        track = 2;
        outlines[2].effectColor = new Color(0, 0, 0);
        outlines[0].effectColor = new Color(255, 255, 255);
        outlines[1].effectColor = new Color(255, 255, 255);
    }

}
