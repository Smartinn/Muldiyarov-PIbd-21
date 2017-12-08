import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class Gui {

	private JFrame frame;
	private JPanel panel;
	private JPanel panelTake;
	private JTextField numPlace;
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
		shoping = new Shop();
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 695, 543);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Former(shoping);
		panel.setBounds(10, 11, 500, 498);
		frame.getContentPane().add(panel);

		JButton btnSetPlane = new JButton(
				"\u0413\u0438\u0442\u0430\u0440\u0430");
		btnSetPlane.setBounds(540, 332, 115, 23);
		btnSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog != null) {
					Interface git = new Gitara(30, 2, 1500, 3, colorDialog);
					int place = shoping.putGitInShoping(git);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваша гитара " + place);
				}

			}
		});
		frame.getContentPane().add(btnSetPlane);

		JButton btnSetFigther = new JButton(
				"\u042D\u043B\u0435\u043A\u0442\u0440\u043E\u043D\u043D\u0430\u044F");
		btnSetFigther.setBounds(540, 366, 115, 23);
		btnSetFigther.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null,
							"JColorChooser Sample", null);
					if (colorDialog != null) {
						Interface git = new Sounds(30, 2, 1500, 3, 2,
								colorDialog, colorDialog1);
						int place = shoping.putGitInShoping(git);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваша гитара "
								+ place);
					}
				}

			}
		});
		frame.getContentPane().add(btnSetFigther);

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

		numPlace = new JTextField();
		numPlace.setBounds(540, 267, 115, 20);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);

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
