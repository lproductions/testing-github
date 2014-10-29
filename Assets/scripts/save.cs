using UnityEngine;
using System.Collections;

public class save : MonoBehaviour {
    public int taxi1 = 1;
    public int busowned1 = 0;
    public int boatowned1 = 0;
    public int boatowned2 = 0;
    public int trainowned1 = 0;
    public int trainowned2 = 0;
    public int undergroundtrainowned1 = 0;
    public int planeowned1 = 0;
    public int planeowned2 = 0;
    public int planeowned3 = 0;
    
	// Use this for initialization
	void Start () {
        
        
        if(!PlayerPrefs.HasKey("bus1owned")){
            PlayerPrefs.SetInt("bus1owned", busowned1);

        }
        if (!PlayerPrefs.HasKey("taxi1owned")) {
            PlayerPrefs.SetInt("taki1owned", taxi1);

        }
        if (!PlayerPrefs.HasKey("boat1owned")) {
            PlayerPrefs.SetInt("boat1owned", boatowned1);

        }
        if (!PlayerPrefs.HasKey("boat2owned")) {
            PlayerPrefs.SetInt("boat2owned", boatowned2);

        }
        if (!PlayerPrefs.HasKey("train1owned")) {
            PlayerPrefs.SetInt("train1owned", trainowned1);

        }
        if (!PlayerPrefs.HasKey("train2owned")) {
            PlayerPrefs.SetInt("train2owned", trainowned2);

        }
        if (!PlayerPrefs.HasKey("undergroundtrain1owned")) {
            PlayerPrefs.SetInt("undergroundtrain1owned", undergroundtrainowned1);

        }
        if (!PlayerPrefs.HasKey("plane1owned")) {
            PlayerPrefs.SetInt("plane1owned", planeowned1);

        }
        if (!PlayerPrefs.HasKey("plane2owned")) {
            PlayerPrefs.SetInt("plane2owned", planeowned2);

        }
        if (!PlayerPrefs.HasKey("plane3owned")) {
            PlayerPrefs.SetInt("plane3owned", planeowned3);

        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
