import java.awt.Graphics;

import javax.swing.JPanel;


public class Former extends JPanel{
	Shop inter;
	
	public Former(Shop inter){
		this.inter = inter;
	}
	
	public void paint(Graphics g){
		super.paint(g);
		inter.draw(g, this.getWidth(),this.getHeight());
	}
	
}