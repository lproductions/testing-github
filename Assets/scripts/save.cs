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
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
