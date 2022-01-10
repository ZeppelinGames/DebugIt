using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Open source debugging tool by Zeppelin Games under MIT license
// https://github.com/ZeppelinGames/DebugIt

public class DebugItTest : MonoBehaviour {

    void Start() {
        //Generic tests. Mostly for me to make sure everything works
        DebugIt.LogIt("Test123");
        DebugIt.LogIt(false);

        DebugIt.LogIt(EE.A);
        DebugIt.LogIt(ee);

        DebugIt.LogIt(new int[] { 10, 20, 50, 23123 });
        DebugIt.LogIt(new string[][] { new string[] { "AA", "AB" }, new string[] { "BA", "BB" } });
        DebugIt.LogIt(new int[][][] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } }, new int[][] { new int[] { 7, 8, 9 }, new int[] { 10, 11, 12 } } });

        DebugIt.LogIt(1, 2, 3, 5);
        DebugIt.LogIt(new string[] { "AA", "AB" }, new string[] { "BA", "BB" });

        DebugIt.LogIt(new DebugTestClass());
    }

    public enum EE { A, B, C };
    private EE ee = EE.A;

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
