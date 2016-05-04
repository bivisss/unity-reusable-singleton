using UnityEngine;

public class MySingletonExample : Singleton<MySingletonExample> {
	protected MySingletonExample () {} // guarantee this will be always a singleton only - can't use the constructor!

	public string globalVar;

	void Awake () {
		Debug.Log("Awoke Singleton Instance: " + gameObject.GetInstanceID());
	}

}
