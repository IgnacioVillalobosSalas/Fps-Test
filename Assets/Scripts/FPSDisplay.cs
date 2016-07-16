using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(FPSCounter))]
public class FPSDisplay : MonoBehaviour {



    FPSCounter Counter;
    public Text fpsLabel;
	// Use this for initialization
	void Awake () {
        Counter = GetComponent<FPSCounter>();
	}
	
	// Update is called once per frame
	void Update () {
        fpsLabel.text = Counter.FPS.ToString();
	}
}
