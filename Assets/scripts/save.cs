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
    public GameObject text;


    // Use this for initialization
    void Start() {
        
        
        if(!PlayerPrefs.HasKey("bus1owned")){
            PlayerPrefs.SetInt("bus1owned", busowned1);

        }
        else {
          busowned1 =  PlayerPrefs.GetInt("bus1owned");

        }




        if (!PlayerPrefs.HasKey("taxi1owned")) {
            PlayerPrefs.SetInt("taki1owned", taxi1);

        }
        else {
            taxi1 = PlayerPrefs.GetInt("bus1owned";

        }




        if (!PlayerPrefs.HasKey("boat1owned")) {
            PlayerPrefs.SetInt("boat1owned", boatowned1);

        }
        else {
           boatowned1 = PlayerPrefs.GetInt("boat1owned");

        }




        if (!PlayerPrefs.HasKey("boat2owned")) {
            PlayerPrefs.SetInt("boat2owned", boatowned2);

        }
        else {

            boatowned2 =  PlayerPrefs.GetInt("boat2owned");
        }




        if (!PlayerPrefs.HasKey("train1owned")) {
            PlayerPrefs.SetInt("train1owned", trainowned1);

        }
        else {
            trainowned1 =  PlayerPrefs.GetInt("train1owned");

        }




        if (!PlayerPrefs.HasKey("train2owned")) {
            PlayerPrefs.SetInt("train2owned", trainowned2);

        }
        else {
            trainowned2 =  PlayerPrefs.GetInt("train2owned");

        }




        if (!PlayerPrefs.HasKey("undergroundtrain1owned")) {
            PlayerPrefs.SetInt("undergroundtrain1owned", undergroundtrainowned1);

        }
        else {

            undergroundtrainowned1 =  PlayerPrefs.GetInt("undergroundtrain1owned");
        }




        if (!PlayerPrefs.HasKey("plane1owned")) {
            PlayerPrefs.SetInt("plane1owned", planeowned1);

        }
        else {
            planeowned1 =  PlayerPrefs.GetInt("plane1owned");

        }



        if (!PlayerPrefs.HasKey("plane2owned")) {
            PlayerPrefs.SetInt("plane2owned", planeowned2);

        }
        else {
            planeowned2 =  PlayerPrefs.GetInt("plane2owned");

        }




        if (!PlayerPrefs.HasKey("plane3owned")) {
            PlayerPrefs.SetInt("plane3owned", planeowned3);

        }
        else {
            planeowned3 =  PlayerPrefs.GetInt("plane3owned");

        }




        if (!PlayerPrefs.HasKey("money")) {
            
            PlayerPrefs.SetInt("money", System.Convert.ToInt32( money.moneyvalue));

        }
        else {
            money.moneyvalue =  PlayerPrefs.GetInt("money");

        }



        if (!PlayerPrefs.HasKey("totalmoney")) {
            PlayerPrefs.SetInt("totalmoney", System.Convert.ToInt32(money.totalmoney));

        }
        else {
            money.totalmoney =  PlayerPrefs.GetInt("totalmoney");

        }




        if (!PlayerPrefs.HasKey("moneypersecond")) {
            PlayerPrefs.SetInt("moneypersecond", System.Convert.ToInt32(money.moneypersecond));

        }
        else {
            money.moneypersecond =  PlayerPrefs.GetInt("moneypersecond");

        }


	}

    // Update is called once per frame
    void Update() {




    }
    public void Save() {
        PlayerPrefs.SetInt("bus1owned", busowned1);


        PlayerPrefs.SetInt("taki1owned", taxi1);



        PlayerPrefs.SetInt("boat1owned", boatowned1);



        PlayerPrefs.SetInt("boat2owned", boatowned2);



        PlayerPrefs.SetInt("train1owned", trainowned1);

        PlayerPrefs.SetInt("train2owned", trainowned2);


        PlayerPrefs.SetInt("undergroundtrain1owned", undergroundtrainowned1);


        PlayerPrefs.SetInt("plane1owned", planeowned1);


        PlayerPrefs.SetInt("plane2owned", planeowned2);


        PlayerPrefs.SetInt("plane3owned", planeowned3);
    }
}
