import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JRadioButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class KitchenGui {

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;

	private egg[] eggs;
	private salt salt;
	private milk milk;
	private maslo maslo;
	private knife knife;
	private skovoroda skov;
	private stove stove;
	private boolean ambrella = false;
	private boolean ambrella2 = false;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					KitchenGui window = new KitchenGui();
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
	public KitchenGui() {
		knife = new knife();
		skov = new skovoroda();
		stove = new stove();
		
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 206);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		textField = new JTextField();
		textField.setBounds(10, 11, 86, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		textField_1 = new JTextField();
		textField_1.setBounds(10, 40, 86, 20);
		frame.getContentPane().add(textField_1);
		textField_1.setColumns(10);

		textField_2 = new JTextField();
		textField_2.setBounds(10, 70, 86, 20);
		frame.getContentPane().add(textField_2);
		textField_2.setColumns(10);

		textField_3 = new JTextField();
		textField_3.setBounds(10, 101, 86, 20);
		frame.getContentPane().add(textField_3);
		textField_3.setColumns(10);

		JLabel lblNewLabel = new JLabel("\u044F\u0439\u0446\u0430");
		lblNewLabel.setBounds(103, 11, 46, 14);
		frame.getContentPane().add(lblNewLabel);

		JLabel lblNewLabel_1 = new JLabel(
				"\u043C\u043E\u043B\u043E\u043A\u043E");
		lblNewLabel_1.setBounds(103, 42, 46, 14);
		frame.getContentPane().add(lblNewLabel_1);

		JLabel label = new JLabel("\u0441\u043E\u043B\u044C");
		label.setBounds(103, 71, 46, 14);
		frame.getContentPane().add(label);

		JLabel label_1 = new JLabel("\u043C\u0430\u0441\u043B\u043E");
		label_1.setBounds(103, 101, 46, 14);
		frame.getContentPane().add(label_1);

		JButton button = new JButton("\u043A\u043E\u043B\u043E\u0442\u044C");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (eggs == null) {
					JOptionPane.showMessageDialog(null, "яица-не взяты",
							"проблема", 0, null);
					return;
				} else
					for (int i = 0; i < eggs.length; ++i) {
						knife.breaker(eggs[i]);
					}
			}
		});
		button.setBounds(174, 10, 89, 23);
		frame.getContentPane().add(button);

		JButton button_1 = new JButton("+\u044F\u0439\u0446\u0430");
		button_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!"".equals(textField.getText())) {
					if (ambrella2 != false) {
						if (Integer.parseInt(textField.getText()) > 0
								&& ambrella == false) {
							eggs = new egg[Integer.parseInt(textField.getText())];
							skov.Init(Integer.parseInt(textField.getText()));
							for (int i = 0; i < eggs.length; i++) {
								eggs[i] = new egg();
							}
							for (int i = 0; i < eggs.length; ++i) {
								eggs[i].setSkin(true);
							}
							ambrella = true;
						}
						if (eggs == null) {
							JOptionPane.showMessageDialog(null, "яиц-нету",
									"проблема", 0, null);
							return;
						}
						for (int i = 0; i < eggs.length; ++i) {
							if (eggs[i].getSkin()) {
								JOptionPane.showMessageDialog(null,
										"яица-скорлупа", "проблема", 0, null);
								return;
							}

						}
						for (int i = 0; i < eggs.length; ++i) {
							skov.AddEggs(eggs[i]);
						}
						JOptionPane.showMessageDialog(null, "яица+", "кухня",
								0, null);
					} else {
						JOptionPane.showMessageDialog(null,
								"Поставь сковороду", "проблема", 0, null);
					}
				}
			}
		});
		button_1.setBounds(315, 10, 89, 23);
		frame.getContentPane().add(button_1);

		JButton button_2 = new JButton("+\u043C\u043E\u043B\u043E\u043A\u043E");
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!"".equals(textField_1.getText())) {
					if (ambrella2 != false) {
						milk = new milk();
						milk.setCount(Integer.parseInt(textField_1.getText()));
						if (milk.getCount() > 0) {
							skov.AddMilk(milk);
							JOptionPane.showMessageDialog(null, "молоко+",
									"кухня", 0, null);
						} else {
							JOptionPane.showMessageDialog(null,
									"молоко--------", "проблема", 0, null);
							return;
						}
					} else {
						JOptionPane.showMessageDialog(null,
								"Поставь сковороду", "проблема", 0, null);
					}
				}
			}
		});
		button_2.setBounds(315, 39, 89, 23);
		frame.getContentPane().add(button_2);

		JButton button_3 = new JButton("+\u0441\u043E\u043B\u044C");
		button_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!"".equals(textField_2.getText())) {
					if (ambrella2 != false) {
						salt = new salt();
						salt.setCount(Integer.parseInt(textField_2.getText()));
						if (salt.getCount() > 0) {
							skov.AddSalt(salt);
							JOptionPane.showMessageDialog(null, "соль+",
									"кухня", 0, null);
						} else {
							JOptionPane.showMessageDialog(null, "соль--------",
									"проблема", 0, null);
							return;
						}
					} else {
						JOptionPane.showMessageDialog(null,
								"Поставь сковороду", "проблема", 0, null);
					}
				}
			}
		});
		button_3.setBounds(315, 69, 89, 23);
		frame.getContentPane().add(button_3);

		JButton button_4 = new JButton("+\u043C\u0430\u0441\u043B\u043E");
		button_4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!"".equals(textField_3.getText())) {
					if (ambrella2 != false) {
						maslo = new maslo();
						maslo.setCount(Integer.parseInt(textField_3.getText()));
						if (maslo.getCount() > 0) {
							skov.AddMaslo(maslo);
							JOptionPane.showMessageDialog(null, "масло+",
									"кухня", 0, null);
						} else {
							JOptionPane.showMessageDialog(null,
									"масло--------", "проблема", 0, null);
							return;
						}
					} else {
						JOptionPane.showMessageDialog(null,
								"Поставь сковороду", "проблема", 0, null);
					}
				}
			}
		});
		button_4.setBounds(315, 100, 89, 23);
		frame.getContentPane().add(button_4);

		JRadioButton radioButton = new JRadioButton("\u0432\u043A\u043B");
		radioButton.addActionListener(new ActionListener(){

			@Override
			public void actionPerformed(ActionEvent arg0) {
				stove.setState(radioButton.isSelected());
			}
			
		});
		radioButton.setBounds(196, 39, 51, 23);
		frame.getContentPane().add(radioButton);

		JButton button_5 = new JButton(
				"+\u0441\u043A\u043E\u0432\u043E\u0440\u0434\u0430");
		button_5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				ambrella2 = true;
			}
		});
		button_5.setBounds(174, 69, 89, 23);
		frame.getContentPane().add(button_5);

		JButton btnNewButton = new JButton(
				"\u0433\u043E\u0442\u043E\u0432\u0438\u0442\u044C");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (radioButton.isSelected() == true && milk != null
						&& eggs != null && salt != null && maslo != null) {
					stove.setScovorods(skov);
					stove.Cook();
					if (skov.IsReady()) {
						JOptionPane.showMessageDialog(null, "готово",
								"кухня", 0, null);
					}
				} else if (radioButton.isSelected() == false) {
					JOptionPane.showMessageDialog(null, "плиту-вкл?",
							"проблема", 0, null);
				} else
					JOptionPane.showMessageDialog(null, "всё добавил?",
							"проблема", 0, null);
			}
		});
		btnNewButton.setBounds(174, 100, 89, 23);
		frame.getContentPane().add(btnNewButton);

		JButton button_6 = new JButton("\u0443\u0431\u0440\u0430\u0442\u044C");
		button_6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!skov.IsReady())
	            {
					JOptionPane.showMessageDialog(null, "неготово",
							"кухня", 0, null);
					return;
	            }
	            else System.exit(1);
			}
		});
		button_6.setBounds(174, 134, 89, 23);
		frame.getContentPane().add(button_6);
	}
}
