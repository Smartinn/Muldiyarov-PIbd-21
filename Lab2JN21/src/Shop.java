import java.awt.Color;
import java.awt.Graphics;

public class Shop {
	ClassShop<Interface> shoping;

	int countPlaces = 6;
	int placeWidth = 140;
	int placeHeight = 250;

	public Shop() {
		shoping = new ClassShop<Interface>(countPlaces, null);
	}

	public int putGitInShoping(Interface git) {
		return shoping.plus(shoping, git);
	}

	public Interface GetGitInShoping(int index) {
		return shoping.minus(shoping, index);
	}

	public void draw(Graphics g, int width, int height) {
		drawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			Interface git = shoping.getObject(i);
			if (git != null) {
				git.setPos(5 + i / 2 * placeWidth + 30, i % 2 * placeHeight
						+ 20);
				git.draw(g);
			}
		}

	}

	public void drawMarking(Graphics g) {
		g.setColor(Color.BLACK);
		for (int i = 0; i < countPlaces / 2; i++) {
			for (int j = 0; j < 4; j++) {
				g.drawLine(i * placeWidth, j * (placeHeight - 10), i
						* placeWidth + 110, j * (placeHeight - 10));
			}
			g.drawLine(i * placeWidth, 0, i * placeWidth, 480);
		}

	}
}
