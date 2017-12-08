import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Sounds extends Gitara implements Serializable {
	transient private Color dopColor;
	private int powerUsilit;
	private boolean notka;

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
	
	private void writeObject(ObjectOutputStream s) throws IOException {
        s.defaultWriteObject();
        s.writeInt(ColorBody.getRed());
        s.writeInt(ColorBody.getGreen());
        s.writeInt(ColorBody.getBlue());
        s.writeInt(dopColor.getRed());
        s.writeInt(dopColor.getGreen());
        s.writeInt(dopColor.getBlue());
    }

    private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
        s.defaultReadObject();
        int red = s.readInt();
        int green = s.readInt();
        int blue = s.readInt();
        ColorBody = new Color(red, green, blue);
        int red1 = s.readInt();
        int green1 = s.readInt();
        int blue1 = s.readInt();
        dopColor = new Color(red1, green1, blue1);
    }

	@Override
	public String getInfo() {
		return MaxSound + ";" + MaxCountMusic + ";" + Weight + ";" + countStrun + ";" + ColorBody + ";" + powerUsilit + ";" + notka + ";" + dopColor;

	}
}
