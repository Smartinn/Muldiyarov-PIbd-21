import java.awt.Color;
import java.awt.Graphics;
import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;

import javax.print.DocFlavor.BYTE_ARRAY;
public class Shop implements Serializable{

	ArrayList<ClassShop<Interface>> shopingStages;
	int countPlaces = 6;
	int placeWidth = 140;
	int placeHeight = 250;
	int currentLevel;

	public Shop(int countStages) {
		shopingStages = new ArrayList<ClassShop<Interface>>(countStages);
		for (int i = 0; i < countStages; i++) {
			shopingStages.add(new ClassShop<Interface>(countPlaces, null));
		}
	}

	public int getCurrentLevel() {
		return currentLevel;
	}

	public void levelUp() {
		if (currentLevel + 1 < shopingStages.size())
			currentLevel++;
	}

	public void levelDown() {
		if (currentLevel > 0)
			currentLevel--;
	}

	public int putGitInShoping(Interface git) {
		return shopingStages.get(currentLevel).plus(
				shopingStages.get(currentLevel), git);
	}

	public Interface GetGitInShoping(int index) {
		return shopingStages.get(currentLevel).minus(
				shopingStages.get(currentLevel), index);
	}

	public void draw(Graphics g, int width, int height) {
		drawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			Interface git = shopingStages.get(currentLevel).getGit(i);
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
	
	public boolean save(String fileName) throws IOException {

		FileOutputStream save = null;
		try {
			save = new FileOutputStream(fileName);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		ObjectOutputStream obSave = new ObjectOutputStream(save);
		System.out.println(shopingStages.get(0).getGit(0).getInfo());
		obSave.writeObject(shopingStages);
		return true;
	}

	public boolean load(String filename) {
		try {
			ObjectInputStream obLoad = new ObjectInputStream(new BufferedInputStream(new FileInputStream(filename)));
			try {
				shopingStages = (ArrayList<ClassShop<Interface>>)obLoad.readObject();
				System.out.println(shopingStages.get(0).getGit(0).getInfo());
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return true;
	}

}
