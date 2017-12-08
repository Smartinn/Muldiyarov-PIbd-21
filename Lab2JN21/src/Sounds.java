import java.awt.Color;
import java.awt.Graphics;

public class Sounds extends Gitara {
	private Color dopColor;
	private int powerUsilit;

	public Sounds(int maxSound, int maxCountMusic, int weight, int countstrun,
			int powerUsilit, Color color, Color dopColor) {
		super(maxSound, maxCountMusic, weight, countstrun, color);
		this.powerUsilit = powerUsilit;
		this.dopColor = dopColor;
	}

	protected void drawSound(Graphics g) {
		g.setColor(dopColor);
		g.fillRect(startPosX, startPosY + 60, 5, 75);
		super.drawSound(g);
	}

	public void setDopColor(Color color) {
		dopColor = color;
	}

}
