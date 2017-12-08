import java.awt.Graphics;

import javax.swing.JPanel;


public class Former extends JPanel{
	Interface inter;
	
	public Former(Interface inter){
		this.inter = inter;
	}
	
	public void paint(Graphics g){
		super.paint(g);
		Git(g,inter);
	}
	
	public void Git(Graphics g,Interface inter){
		if(inter!=null){
			inter.draw(g);
		}
	}
}