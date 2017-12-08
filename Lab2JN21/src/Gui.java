import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class Gui {

	private JFrame frame;
	private JPanel panel;
	private JPanel panelTake;
	private JTextField numPlace;
	private String[] elements = new String[6];
	JList listLevels;
	Shop shoping;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Gui window = new Gui();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 * 
	 * @wbp.parser.entryPoint
	 */
	public Gui() {
		shoping = new Shop(5);
		initialize();

		for (int i = 0; i < 5; i++) {
			elements[i] = "Уровнь " + (i + 1);
		}

		listLevels.setSelectedIndex(shoping.getCurrentLevel());
	}

	/**
	 * Initialize the contents of the frame.
	 */

	public void getGit() {
		SelectGui select = new SelectGui(frame);
		if (select.res()) {
			Interface git = select.getGit();
			int place = shoping.putGitInShoping(git);
			panel.repaint();
		}
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 874, 618);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		panel = new Former(shoping);
		panel.setBounds(10, 11, 500, 498);
		frame.getContentPane().add(panel);

		panelTake = new JPanel();
		panelTake.setBounds(540, 11, 115, 245);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("\u0412\u0437\u044F\u0442\u044C");
		btnTake.setBounds(540, 298, 115, 23);
		btnTake.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (checkPlace(numPlace.getText())) {
					Interface plane = shoping.GetGitInShoping(Integer
							.parseInt(numPlace.getText()));
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(),
							panelTake.getHeight());
					plane.setPos(35, 10);
					plane.draw(gr);
					panel.repaint();
				}

			}
		});
		frame.getContentPane().add(btnTake);

		JButton btnGetGit = new JButton("Получить гитару");
		btnGetGit.addActionListener(new ActionListener() {
			@SuppressWarnings("deprecation")
			public void actionPerformed(ActionEvent e) {
				getGit();
			}
		});
		btnGetGit.setBounds(540, 321, 115, 23);
		frame.getContentPane().add(btnGetGit);

		numPlace = new JTextField();
		numPlace.setBounds(540, 267, 115, 20);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);

		listLevels = new JList(elements);
		listLevels.setBounds(668, 11, 186, 111);
		frame.getContentPane().add(listLevels);

		JButton btnLevelDown = new JButton("<<");
		btnLevelDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				shoping.levelDown();
				listLevels.setSelectedIndex(shoping.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelDown.setBounds(665, 133, 89, 23);
		frame.getContentPane().add(btnLevelDown);

		JButton btnLevelUp = new JButton(">>");
		btnLevelUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				shoping.levelUp();
				listLevels.setSelectedIndex(shoping.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelUp.setBounds(765, 133, 89, 23);
		frame.getContentPane().add(btnLevelUp);
		
		JMenuBar menuBar = new JMenuBar();
		JMenu menu = new JMenu("File");
		frame.setJMenuBar(menuBar);
		menuBar.add(menu);
		JMenuItem menuSave = new JMenuItem("Save");
		menu.add(menuSave);
		JMenuItem menuOpen = new JMenuItem("Open");
		menu.add(menuOpen);

		menuSave.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				JFileChooser filesave = new JFileChooser();

				if (filesave.showDialog(null, "Save") == JFileChooser.APPROVE_OPTION) {
					try {
						if (shoping.save(filesave.getSelectedFile().getPath()))
							if (filesave.getSelectedFile().getPath() != null)
								System.out.println("Good");
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}
		});

		menuOpen.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser fileopen = new JFileChooser();
				if (fileopen.showDialog(null, "Open") == JFileChooser.APPROVE_OPTION) {
					if (shoping.load(fileopen.getSelectedFile().getPath()))
						if (fileopen.getSelectedFile().getPath() != null)
							System.out.println("Good");
				}
				panel.repaint();
			}
		});

	}
	

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}
}
