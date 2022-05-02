#pragma strict


var ballSpeed: float = 80;

function Start() {
    yield WaitForSeconds(2);
    goBall();
}

function Update() {
    var xVel: float = GetComponent.<Rigidbody2D>().velocity.x;
    if (xVel < 18 && xVel > -18 && xVel != 0) {
        if (xVel > 0) {
            GetComponent.<Rigidbody2D>().velocity.x = 20;
        }
        else {
            GetComponent.<Rigidbody2D>().velocity.x = -20;
        }
    }
}
function NewBall() {
    GetComponent.<Rigidbody2D>().velocity.y = 0;
    GetComponent.<Rigidbody2D>().velocity.x = 0;
    transform.position.x = 0;
    transform.position.y = 0;
    yield WaitForSeconds(1.5f);///////////////////////////////////
    GetComponent.<AudioSource>().Play();
    goBall();
}

function ResetBall() {
    GetComponent.<Rigidbody2D>().velocity.y = 0;
    GetComponent.<Rigidbody2D>().velocity.x = 0;
    transform.position.x = 0;
    transform.position.y = 0;
    yield WaitForSeconds(0.5f);
    goBall();
}

function goBall() {
    var randomNumber = Random.Range(0f, 1f);
    if (randomNumber <= 0.5f) {
        GetComponent.<Rigidbody2D>().AddForce(new Vector2(ballSpeed, 10));
    }
    else {
        GetComponent.<Rigidbody2D>().AddForce(new Vector2(-ballSpeed, -10));
    }
}

function OnCollisionEnter2D(colInfo: Collision2D) {
    if (colInfo.collider.tag == "Player") {
        GetComponent.<Rigidbody2D>().velocity.y = GetComponent.<Rigidbody2D>().velocity.y / 2 + colInfo.collider.GetComponent.<Rigidbody2D>().velocity.y / 3;
        GetComponent.<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
        GetComponent.<AudioSource>().Play();
    }

}