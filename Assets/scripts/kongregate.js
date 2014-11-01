var isKongregate = false;
var userId = 0;
static var username = "Guest";
var gameAuthToken = "";
var text : GameObject;
public var fading : boolean = true;

 
function OnKongregateAPILoaded(userInfoString){
  // We now know we're on Kongregate
  isKongregate = true;
  
 
  // Split the user info up into tokens
  var params = userInfoString.Split("|"[0]);
  userId = parseInt(params[0]);
  username = params[1];
  gameAuthToken = params[2];
  
  
}


function Example() {
while (true){
      
		text.GetComponent(UI.Text).color.a =0;
		
        yield new WaitForSeconds(60);
		 
        text.GetComponent(UI.Text).color.a = 1;

		Camera.main.GetComponent(save).Save();
         yield WaitForSeconds(5);
    
		
		  

	
		 

        
        
    }
	
	}
	
 

function Awake()
    {
    // Begin the API loading process if it is available

    
    // This game object needs to survive multiple levels
    
 DontDestroyOnLoad(gameObject);
 StartCoroutine(Example());
    // Begin the API loading process if it is available
Application.ExternalEval(
  "if(typeof(kongregateUnitySupport) != 'undefined'){" +
  " kongregateUnitySupport.initAPI('kongregateapi', 'OnKongregateAPILoaded');" +
  "};"
);
    }
