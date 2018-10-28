using UnityEngine;
using LiteNetLib.Utils;

public class SimplePacket
{
    public string Login { get; set; }
    public string Password { get; set; }
}

public class SerializerTestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        NetSerializer serializer = new NetSerializer();

        SimplePacket packet = new SimplePacket()
        {
            Login = "login",
            Password = "MyCatNameIsBilly"
        };

        serializer.Serialize(packet);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
