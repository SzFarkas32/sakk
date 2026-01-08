using System;

public class Babu	
{
	string color;


    //enumot használunk a megkülönböztetéshez
    enum Tipus {
		paraszt,
		huszar,
		futo,
		bastya,
		vezer,
        kiraly
    }
	Tipus tipus;
    public Babu(string color, Tipus tipus)
	{
		this.color = color;
		this.tipus = tipus;
    }
}
