using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugItTest : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        //Generic tests
        Debug.Log("Debugging generic types");

        DebugIt.LogIt("Test123");
        DebugIt.LogIt(false);

        DebugIt.LogIt(EE.A);
        DebugIt.LogIt(ee);

        DebugIt.LogIt(new int[] { 10, 20, 50, 23123 });
        DebugIt.LogIt(new string[][] { new string[] { "AA", "AB" }, new string[] { "BA", "BB" } });

        DebugIt.LogIt(1, 2, 3, 5);
        DebugIt.LogIt(new string[] { "AA", "AB" }, new string[] { "BA", "BB" });

        DebugIt.LogIt(new DebugTestClass());
    }

    public enum EE { A, B, C};
    public EE ee = EE.A;

    private class DebugTestClass {
        public string testString = "test str";
        public char testChar = (char)65;
        public bool testBool = true;
        public int testInt = 1023;
        public float testFloat = 10.523f;
        public double testDouble = 10.24;

        public string[] testStrArr = new string[] { "Test 1", "Test 2", "Test 3" };
    }
}
