
public class stove {
	private skovoroda skovorods;
	
	private boolean State = false;
    public void setState(boolean m){
    	State = m;
    }
    
    public boolean getState(){
    	return State;
    }
    
    public void setScovorods(skovoroda value){
    	skovorods = value;
    }
    
    public skovoroda getScovorods(){
    	return skovorods;
    }

    public void Cook()
    {
        if (State)
        {
            while (skovorods.IsReady() == false)
            {
                skovorods.GetHeat();
            }
        }
    }
}
