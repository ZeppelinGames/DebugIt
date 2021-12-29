using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public static class DebugIt {

    private static string NEWLINE = "\n";

    private static List<Type> _systemTypes;
    private static List<Type> SystemTypes {
        get {
            if (_systemTypes == null) {
                _systemTypes = Assembly.GetExecutingAssembly().GetType().Module.Assembly.GetExportedTypes().ToList();
            }
            return _systemTypes;
        }
    }

    private static bool IsSystemType<T>(T t) {
        return SystemTypes.Contains(t.GetType());
    }

    private static string AnyToString<T>(T generic) {
        if (generic.GetType().IsArray) {
            return ArrayToString(generic as T[]); //Need to work out nested arrays
        }
        if (generic.GetType().IsEnum) {
            return EnumToString(generic as Enum);
        }
        if (!IsSystemType(generic) && generic.GetType().IsClass) { //Make sure its not sys class but a custom one. WILL OVERFLOW
            return ClassToString(generic);
        }
        return TypeToString(generic);
    }

    private static string TypeToString<T>(T generic) {
        return generic.ToString();
    }

    private static string ArrayToString<T>(T[] arr) {
        string debugStr = "[";
        if (arr != null) {
            for (int i = 0; i < arr.Length; i++) {
                debugStr += AnyToString(arr[i]) + (i < arr.Length - 1 ? ", " : "");
            }
        }
        debugStr += "]";
        return debugStr;
    }

    private static string ClassToString<T>(T gClass) {
        FieldInfo[] fields = gClass.GetType().GetFields();

        string debugStr = gClass.GetType().Name + NEWLINE;
        for (int i = 0; i < fields.Length; i++) {
            debugStr += $"{fields[i].Name} ({fields[i].FieldType.Name}): {AnyToString(fields[i].GetValue(gClass))} {NEWLINE}";
        }
        return debugStr;
    }

    private static string EnumToString(Enum e) {
        string debugStr = "{";
        Array enumVals = Enum.GetValues(e.GetType());
        for (int i = 0; i < enumVals.Length; i++) {
            debugStr += $"{enumVals.GetValue(i)} ({i})" + (i < enumVals.Length - 1 ? ", " : "");
        }

        debugStr += "}";
        return debugStr;
    }

    /// <summary>
    /// (try) Log anything
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="generic">Thing to log</param>
    public static void LogIt<T>(T generic) {
        Debug.Log(AnyToString(generic));
    }

    /// <summary>
    /// (try) Log anything
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="genericParams">Array of thing to log</param>
    public static void LogIt<T>(params T[] genericParams) {
        Debug.Log(ArrayToString(genericParams));
    }

    /// <summary>
    /// Logs generic type variable
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    /// <param name="generic">Variable to log</param>
    public static void LogGeneric<T>(T generic) {
        Debug.Log(TypeToString(generic));
    }

    /// <summary>
    /// Logs array of generic type variable
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    /// <param name="genericArr">Array of generic type to log</param>
    public static void LogGenericArray<T>(T[] genericArr) {
        Debug.Log(ArrayToString(genericArr));
    }

    /// <summary>
    /// Logs class data
    /// </summary>
    /// <typeparam name="T">Class type to log</typeparam>
    /// <param name="gClass">Clas to log</param>
    /// 
    // Logs to console in this format:
    // <class name>
    // <param name> (<param type>): <param value>
    // ...
    public static void LogClass<T>(T gClass) {
        FieldInfo[] fields = gClass.GetType().GetFields();

        string debugStr = gClass.GetType().Name + NEWLINE;
        for (int i = 0; i < fields.Length; i++) {
            debugStr += $"{fields[i].Name} ({fields[i].FieldType.Name}): {fields[i].GetValue(gClass).ToString()} {NEWLINE}";
        }

        Debug.Log(debugStr);
    }
}

