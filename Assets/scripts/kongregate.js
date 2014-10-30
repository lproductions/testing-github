var isKongregate = false;
var userId = 0;
static var username = "Guest";
var gameAuthToken = "";
var text : GameObject;


 
function OnKongregateAPILoaded(userInfoString){
  // We now know we're on Kongregate
  isKongregate = true;
  
 
  // Split the user info up into tokens
  var params = userInfoString.Split("|"[0]);
  userId = parseInt(params[0]);
  username = params[1];
  gameAuthToken = params[2];
  StartCoroutine(Example());
  
}
function Example() {
while (true){
        Application.ExternalCall("kongregate.stats.submit","TotalMoney",text.gameObject.transform.parent.GetComponent(money).totalmoney);
        yield new WaitForSeconds(60);
        text.GetComponent(UI.Text).text = "Game saved";
         yield WaitForSeconds(5);
         text.GetComponent(UI.Text).text = "";
        }
        
    }
 

function Awake()
    {
    // Begin the API loading process if it is available

    
    // This game object needs to survive multiple levels
    
 DontDestroyOnLoad(gameObject);
    // Begin the API loading process if it is available
Application.ExternalEval(
  "if(typeof(kongregateUnitySupport) != 'undefined'){" +
  " kongregateUnitySupport.initAPI('kongregateapi', 'OnKongregateAPILoaded');" +
  "};"
);
    }