using UnityEngine;
using System.Collections;

public class money : MonoBehaviour {

	// Use this for initialization
    static double money = 10000;
    static long moneypersecond;
	void Start () {
        StartCoroutine(moneypersecondsomething());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    IEnumerator moneypersecondsomething() {
        money += moneypersecond / 10;
        yield return new WaitForSeconds(0.1f);
        moneypersecondsomething();
    }
}
