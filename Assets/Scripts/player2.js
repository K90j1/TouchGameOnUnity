#pragma strict
function Update () {
  if (Input.GetMouseButtonDown(0)){ // if left button pressed...
    var hit: RaycastHit;
    var ray: Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	Debug.Log(ray);
	Debug.Log(hit);
    if (Physics.Raycast(ray, hit) && hit.transform.name=="Map"){
      // hit.point contains the point where the ray hits the
      // object named "Map"
    }
  }
}