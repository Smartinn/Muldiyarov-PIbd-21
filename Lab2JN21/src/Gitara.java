import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.util.Random;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Gitara extends Guid implements Serializable {
	public int getMaxCountMusic() {
		return super.MaxCountMusic;
	}

	protected void setMaxCountMusic(int value) {
		if (value > 0 && value < 2) {
			super.MaxCountMusic = value;
		} else {
			super.MaxCountMusic = 1;
		}
	}

	public int getMaxSound() {
		return super.MaxSound;
	}

	protected void setMaxSound(int value) {
		if (value > 0 && value < 100) {
			super.MaxSound = value;
		} else {
			super.MaxSound = 50;
		}
	}

	public int getcountStrun() {
		return super.countStrun;
	}

	protected void setcountStrun(int value) {
		if (value > 4 && value < 8) {
			super.countStrun = value;
		} else {
			super.countStrun = 6;
		}
	}

	public int getWeight() {
		return super.Weight;
	}

	protected void setWeight(int value) {
		if (value > 1 && value < 15) {
			super.Weight = value;
		} else {
			super.Weight = 3;
		}
	}

	public Gitara(int maxSound, int maxCountMusic, int weight, int countstrun,
			Color color) {
		this.MaxSound = maxSound;
		this.countStrun = countstrun;
		this.MaxCountMusic = maxCountMusic;
		this.ColorBody = color;
		this.Weight = weight;
		Random rand = new Random();
		startPosX = 100;
		startPosY = 100;
	}

	public void setPos(int x, int y) {
		startPosX = x;
		startPosY = y + 50;
	}

	public void setMainColor(Color c) {
		ColorBody = c;
	}

	public void makesound(Graphics g) {
		draw(g);
		drawSounds(g);
	}

	public void draw(Graphics g) {
		drawSound(g);
	}

	protected void drawSound(Graphics g) {
		Graphics2D g2 = (Graphics2D) g;
		BasicStroke pen1 = new BasicStroke(3);
		g2.setStroke(pen1);
		g2.setColor(ColorBody);
		g2.fillOval(startPosX - 5, startPosY + 25, 55, 55);
		g2.setColor(Color.BLACK);
		g2.fillOval(startPosX + 13, startPosY + 41, 20, 20);
		g2.drawArc(startPosX - 5, startPosY + 25, 55, 55, 0, 360);
		g2.setColor(ColorBody);
		g2.fillOval(startPosX, startPosY, 45, 35);
		g2.setColor(Color.BLACK);
		g2.drawArc(startPosX, startPosY, 45, 35, -45, 270);
		g2.setColor(new Color(139, 69, 19));
		g2.fillRect(startPosX + 18, startPosY - 50, 10, 85);
		g2.fillRect(startPosX + 15, startPosY + 63, 16, 4);
		pen1 = new BasicStroke(1);
		g2.setColor(Color.BLACK);
		g2.drawRect(startPosX + 18, startPosY - 50, 10, 85);
		g2.drawRect(startPosX + 15, startPosY + 63, 16, 4);
		g2.setColor(new Color(139, 69, 19));
		g2.fillRect(startPosX + 16, startPosY - 55, 14, 20);
		g2.setColor(Color.BLACK);
		g2.drawRect(startPosX + 16, startPosY - 55, 14, 20);
	}

	protected void drawSounds(Graphics g) {
		Graphics2D g2 = (Graphics2D) g;
		BasicStroke pen2 = new BasicStroke(3);
		g2.setStroke(pen2);
		g2.setColor(Color.BLACK);
		for (int i = 0; i < (int) (Weight * countStrun * MaxSound
				* MaxCountMusic / 8 + 2); i++) {
			g2.drawArc(startPosX + i * 5, startPosY - 5 * i, 60 + 10 * i,
					60 + 10 * i, 315, 90);
		}

	}

	@Override
	public String getInfo() {
		return MaxSound + ";" + MaxCountMusic + ";" + Weight + ";" + countStrun
				+ ";" + ColorBody;
	}

	private void writeObject(ObjectOutputStream s) throws IOException {
		s.defaultWriteObject();
		s.writeInt(ColorBody.getRed());
		s.writeInt(ColorBody.getGreen());
		s.writeInt(ColorBody.getBlue());
	}

	private void readObject(ObjectInputStream s) throws IOException,
			ClassNotFoundException {
		s.defaultReadObject();
		int red = s.readInt();
		int green = s.readInt();
		int blue = s.readInt();
		ColorBody = new Color(red, green, blue);
	}

	public int compareTo(Gitara gitara) {
		// TODO Auto-generated method stub
		if (gitara == null)
			return 1;
		if (MaxSound != gitara.MaxSound)
			return (MaxSound + "").compareTo(gitara.MaxSound + "");
		if (MaxCountMusic != gitara.MaxCountMusic)
			return (MaxCountMusic + "").compareTo(gitara.MaxCountMusic + "");
		if (Weight != gitara.Weight)
			return (Weight + "").compareTo(gitara.Weight + "");
		if (countMusic != gitara.countMusic)
			return (countMusic + "").compareTo(gitara.countMusic + "");
		if (ColorBody != gitara.ColorBody)
			return ColorBody.toString().compareTo(gitara.ColorBody.toString());
		return 0;
	}

	public boolean equals(Gitara other) {
		if (other == null)
			return false;
		if (MaxSound != other.MaxSound) {
			return false;
		}
		if (MaxCountMusic != other.MaxCountMusic) {
			return false;
		}
		if (Weight != other.Weight) {
			return false;
		}
		if (countMusic != other.countMusic) {
			return false;
		}
		if (ColorBody != other.ColorBody) {
			return false;
		}
		return true;
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null) {
			return false;
		}
		Gitara gitObj = (Gitara) obj;
		if (gitObj == null) {
			return false;
		} else
			return equals(gitObj);
	}
}
