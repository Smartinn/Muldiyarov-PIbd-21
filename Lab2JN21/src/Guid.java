import java.awt.Color;
import java.awt.Graphics;


public abstract class Guid implements Interface{
	
	protected int startPosX;

    protected int startPosY;

    protected int countMusic;

    public int MaxCountMusic;
    
    public int getMaxCountMusic(){
    	return MaxCountMusic;
    }
    
    protected void setMaxCountMusic(int maxCountMusic){
    	this.MaxCountMusic = maxCountMusic; 
    }

    public int MaxSound;
    
    public int getMaxSound(){
    	return MaxSound;
    }
    
    protected void setMaxSound(int maxSound){
    	this.MaxSound = maxSound; 
    }

    public int countStrun;
    
    public int countStrun(){
    	return countStrun;
    }
    
    protected void setcountStrun(int countStrun){
    	this.countStrun = countStrun; 
    }

    public Color ColorBody;
    
    public Color getColorBody(){
    	return ColorBody;
    }
    
    protected void setColorBody(Color colorBody){
    	this.ColorBody = colorBody;
    }

    public int Weight;
    
    public int getWeight(){
    	return Weight;
    }
    
    protected void setWeight(int weight){
    	this.Weight = weight; 
    }

    public abstract void makesound(Graphics g);

    public abstract void draw(Graphics g);

    public void setPosition(int x, int y)
    {
        startPosX = x;
        startPosY = y;
    }

    public void loadMusic(int count)
    {
        if(countMusic + count < MaxCountMusic)
        {
            countMusic += count;
        }
    }
    
    public int getMusic()
    {
        int count = countMusic;
        countMusic = 0;
        return count;
    }


}
