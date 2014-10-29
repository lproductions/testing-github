using UnityEngine;
using System.Collections;

public class money : MonoBehaviour {

	// Use this for initialization
    static double moneyvalue = 10000D;
    static double moneypersecond = 1D;
	void Start () {
        StartCoroutine(moneypersecondsomething());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    IEnumerator moneypersecondsomething() {
        while (true) {
            addmoney();
            yield return new WaitForSeconds(0.1f);
        }
    }
    void addmoney() {
        
        moneyvalue += moneypersecond / 10;
        
        
    }
}
