﻿var isKongregate = false;
var userId = 0;
static var username = "Guest";
var gameAuthToken = "";

 
function OnKongregateAPILoaded(userInfoString){
  // We now know we're on Kongregate
  isKongregate = true;
  
 
  // Split the user info up into tokens
  var params = userInfoString.Split("|"[0]);
  userId = parseInt(params[0]);
  username = params[1];
  gameAuthToken = params[2];
}
 

function Awake()
    {
    
    
    // This game object needs to survive multiple levels
    
 DontDestroyOnLoad(gameObject);
    // Begin the API loading process if it is available
Application.ExternalEval(
  "if(typeof(kongregateUnitySupport) != 'undefined'){" +
  " kongregateUnitySupport.initAPI('kongregateapi', 'OnKongregateAPILoaded');" +
  "};"
);
    }