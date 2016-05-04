# Unity Reusable Singleton
Singleton design pattern that can be extended on subclasses.

Using this script, You will not need to write the singleton initializers in your classes. Just make your class extends Singleton and it will automatically have the singleton features.

This is a MonoBehaviour script, so you can use the Coroutines.

## How to use

1. Copy Singleton.cs script to your project.
2. Make your class extends Singleton.

  Example:
  ```unity
  public class MySingletonExample : Singleton<MySingletonExample> {
  	protected MySingletonExample () {} // guarantee this will be always a singleton only - can't use the constructor!
  
  	public string globalVar;
  
	void Awake () {
  		Debug.Log("Awoke Singleton Instance: " + gameObject.GetInstanceID());
  	}
  }
  ```
3. Now you can call your singleton class by Instance:

  ````unity
  MySingletonExample.Instance.globalVar = "A";
  Debug.Log ("globalVar: " + MySingletonExample.Instance.globalVar);
  ````

#### Sources:
This script is based on following article http://wiki.unity3d.com/index.php/Singleton
