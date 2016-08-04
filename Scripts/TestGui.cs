using UnityEngine;
using System.Collections;

public class TestGui : MonoBehaviour {

    private BaseWarriorClass class1 = new BaseWarriorClass();

    private BaseMageClass class2 = new BaseMageClass();

    private BaseRangerClass class3 = new BaseRangerClass();

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.Label(class1.ClassName);
        GUILayout.Label(class1.ClassDescription);

        GUILayout.Label(class2.ClassName);
        GUILayout.Label(class2.ClassDescription);

        GUILayout.Label(class3.ClassName);
        GUILayout.Label(class3.ClassDescription);
    }
}
