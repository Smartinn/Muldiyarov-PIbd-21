
public class egg {
	private int ready = 0;
	
	private boolean skin = true;
	
	public void setSkin(boolean s){
		skin = s;
	}
	
	public boolean getSkin(){
		return skin;
	}
	
	public int getReady(){
		return ready;
	}
	
	public void heat(){
		while (ready < 10) ready++;
	}
}
