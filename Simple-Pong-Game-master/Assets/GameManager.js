#pragma strict

var theSkin: GUISkin;

static var PlayerScore1: int = 0;
static var PlayerScore2: int = 0;

var theBall: Transform;

function Start() {
    theBall = GameObject.Find("Ball").transform;
}

static function Score(wallName: String) {
    if (wallName == "rightWall")++PlayerScore1;
    else ++PlayerScore2;
    if (PlayerScore2 == 10 || PlayerScore1 == 10) {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        var theBall: Transform;

        theBall = GameObject.Find("Ball").transform;
        theBall.gameObject.SendMessage("NewBall");
   
    }
}

function OnGUI() {
    GUI.skin = theSkin;
    GUI.Label(new Rect(Screen.width / 2 - 350, 20, 500, 500), "" + PlayerScore1);
    GUI.Label(new Rect(Screen.width / 2 + 150, 20, 500, 500), "" + PlayerScore2);

    if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, 35, 121, 53), "RESET")) {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        theBall = GameObject.Find("Ball").transform;

        theBall.gameObject.SendMessage("NewBall");
    }
}