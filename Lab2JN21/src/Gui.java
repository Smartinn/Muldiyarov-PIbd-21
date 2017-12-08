import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class Gui {

	private JFrame frame;
	private JPanel panel;
	private Color color;
	private Color dopColor;
	private int maxSound;
	private int maxCountMusic;
	private int weight;
	private int powerUsilit;
	private int countstrun;

	private Interface inter;

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
	 */
	public Gui() {
		initialize();
		color = Color.WHITE;
		dopColor = Color.YELLOW;
		maxSound = 150;
		maxCountMusic = 4;
		weight = 15;
		powerUsilit = 1;
		countstrun = 3;
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 745, 635);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JTextArea textArea = new JTextArea();
		textArea.setBounds(10, 487, 102, 21);
		frame.getContentPane().add(textArea);

		JTextArea textArea_1 = new JTextArea();
		textArea_1.setBounds(10, 516, 102, 21);
		frame.getContentPane().add(textArea_1);

		JTextArea textArea_2 = new JTextArea();
		textArea_2.setBounds(122, 516, 102, 22);
		frame.getContentPane().add(textArea_2);

		JTextArea textArea_3 = new JTextArea();
		textArea_3.setBounds(122, 487, 102, 22);
		frame.getContentPane().add(textArea_3);

		JTextArea textArea_4 = new JTextArea();
		textArea_4.setBounds(234, 487, 102, 21);
		frame.getContentPane().add(textArea_4);

		JButton btnGitara = new JButton("Gitara");
		btnGitara.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (!textArea.getText().equals("")
						&& !textArea_1.getText().equals("")
						&& !textArea_2.getText().equals("")
						&& !textArea_3.getText().equals("")) {
					maxSound = Integer.parseInt(textArea.getText());
					maxCountMusic = Integer.parseInt(textArea_1.getText());
					weight = Integer.parseInt(textArea_2.getText());
					countstrun = Integer.parseInt(textArea_3.getText());
					inter = new Gitara(maxSound, maxCountMusic, weight,
							countstrun, color);
					panel = new Former(inter);
					panel.setBounds(12, 13, 794, 473);
					frame.getContentPane().add(panel);
					panel.updateUI();
				}
			}
		});
		btnGitara.setBounds(10, 432, 147, 44);
		frame.getContentPane().add(btnGitara);

		JButton btnColor_1 = new JButton("Color1");
		btnColor_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				color = JColorChooser.showDialog(btnColor_1, "öâåò", color);
			}
		});
		btnColor_1.setBounds(234, 516, 102, 25);
		frame.getContentPane().add(btnColor_1);

		JButton btnColor = new JButton("Color2");
		btnColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				dopColor = JColorChooser.showDialog(btnColor_1, "öâåò",
						dopColor);
			}
		});
		btnColor.setBounds(346, 487, 102, 25);
		frame.getContentPane().add(btnColor);

		JButton btnElgitara = new JButton("ElGitara");
		btnElgitara.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (!textArea.getText().equals("")
						&& !textArea_1.getText().equals("")
						&& !textArea_2.getText().equals("")
						&& !textArea_3.getText().equals("")) {
					maxSound = Integer.parseInt(textArea.getText());
					maxCountMusic = Integer.parseInt(textArea_1.getText());
					weight = Integer.parseInt(textArea_2.getText());
					countstrun = Integer.parseInt(textArea_3.getText());
					powerUsilit = Integer.parseInt(textArea_4.getText());
					inter = new Sounds(maxSound, maxCountMusic, weight,
							countstrun, powerUsilit, color, dopColor);
					panel = new Former(inter);
					panel.setBounds(12, 13, 794, 473);
					frame.getContentPane().add(panel);
					panel.updateUI();
				}
			}
		});
		btnElgitara.setBounds(167, 432, 147, 44);
		frame.getContentPane().add(btnElgitara);

		JButton btnSound = new JButton("Sound");
		btnSound.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (!textArea.getText().equals("")
						&& !textArea_1.getText().equals("")
						&& !textArea_2.getText().equals("")
						&& !textArea_3.getText().equals("") && inter != null) {
					inter.makesound(panel.getGraphics());
				}
			}
		});
		btnSound.setBounds(346, 516, 102, 25);
		frame.getContentPane().add(btnSound);
	}
}
