using UnityEngine;

public class TestComponent : MonoBehaviour 
{
  bool depTrai = false;
  private void Start() {
    Debug.Log(depTrai);
    Debug.Log("Test class is dep trai ok");
  }
}