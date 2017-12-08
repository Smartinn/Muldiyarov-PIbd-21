import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.SystemColor;
import java.awt.datatransfer.DataFlavor;
import java.awt.datatransfer.UnsupportedFlavorException;
import java.awt.dnd.DnDConstants;
import java.awt.dnd.DropTarget;
import java.awt.dnd.DropTargetDragEvent;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.IOException;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.TransferHandler;

public class SelectGui extends JDialog {

	Interface git = null;
	JPanel panel;
	boolean r;

	public SelectGui(JFrame frame) {
		super(frame, true);
		main();
	}

	public boolean res() {
		setVisible(true);
		return r;
	}

	public void main() {
		this.getContentPane().setBackground(SystemColor.controlHighlight);
		this.setBounds(100, 100, 491, 379);
		this.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		this.getContentPane().setLayout(null);

		JLabel lblPlane = new JLabel("Gitara");
		lblPlane.setBounds(10, 11, 125, 42);
		this.getContentPane().add(lblPlane);

		JLabel lblFighter = new JLabel("EGitara");
		lblFighter.setBounds(10, 66, 125, 39);
		this.getContentPane().add(lblFighter);

		panel = new JPanel();
		FlowLayout flowLayout = (FlowLayout) panel.getLayout();
		panel.setBounds(145, 11, 163, 169);
		this.getContentPane().add(panel);

		MouseListener mouseL = new MouseListener() {

			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				JComponent jc = (JComponent) e.getSource();
				TransferHandler th = jc.getTransferHandler();
				th.exportAsDrag(jc, e, TransferHandler.COPY);
			}

			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub

			}

		};

		lblPlane.addMouseListener(mouseL);
		lblFighter.addMouseListener(mouseL);
		lblFighter.setTransferHandler(new TransferHandler("text"));
		lblPlane.setTransferHandler(new TransferHandler("text"));

		panel.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {

				try {

					for (DataFlavor df : e.getTransferable()
							.getTransferDataFlavors()) {
						if (e.getTransferable().getTransferData(df) == "Gitara") {
							git = new Gitara(30, 2, 1500, 3, Color.WHITE);
						} else if (e.getTransferable().getTransferData(df) == "EGitara") {
							git = new Sounds(30, 2, 1500, 3, 2, Color.WHITE,
									Color.BLACK);
						}
						draw(panel, git);
					}
				} catch (Exception ex) {
				}

			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (Exception e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});

		JLabel lblMainColor = new JLabel("Color");
		lblMainColor.setBounds(145, 191, 163, 39);
		this.getContentPane().add(lblMainColor);

		JLabel lblDopColor = new JLabel("DopColor");
		lblDopColor.setBounds(145, 250, 163, 39);
		this.getContentPane().add(lblDopColor);

		lblMainColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (git != null) {
					try {
						for (DataFlavor df : e.getTransferable()
								.getTransferDataFlavors()) {
							git.setMainColor((selectColor(e.getTransferable()
									.getTransferData(df).toString())));
							draw(panel, git);
						}
					} catch (Exception ex) {
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});
		lblDopColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (git != null) {
					try {

						for (DataFlavor df : e.getTransferable()
								.getTransferDataFlavors()) {
							((Sounds) git).setDopColor((selectColor(e
									.getTransferable().getTransferData(df)
									.toString())));
							draw(panel, git);
						}
					} catch (Exception ex) {
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});

		JPanel panelYellow = new JPanel();
		panelYellow.setName("yellow");
		panelYellow.setBackground(Color.YELLOW);
		panelYellow.setBounds(347, 29, 46, 39);
		this.getContentPane().add(panelYellow);

		JPanel panelBlue = new JPanel();
		panelBlue.setName("blue");
		panelBlue.setBackground(Color.BLUE);
		panelBlue.setBounds(403, 29, 46, 39);
		this.getContentPane().add(panelBlue);

		JPanel panelRed = new JPanel();
		panelRed.setName("red");
		panelRed.setBackground(Color.RED);
		panelRed.setBounds(347, 79, 46, 39);
		this.getContentPane().add(panelRed);

		JPanel panelGreen = new JPanel();
		panelGreen.setName("green");
		panelGreen.setBackground(Color.GREEN);
		panelGreen.setBounds(403, 79, 46, 39);
		this.getContentPane().add(panelGreen);

		JPanel panelBlack = new JPanel();
		panelBlack.setName("black");
		panelBlack.setBackground(Color.BLACK);
		panelBlack.setBounds(347, 129, 46, 39);
		this.getContentPane().add(panelBlack);

		JPanel panelPink = new JPanel();
		panelPink.setName("pink");
		panelPink.setBackground(Color.PINK);
		panelPink.setBounds(403, 129, 46, 39);
		this.getContentPane().add(panelPink);

		JPanel panelMagenta = new JPanel();
		panelMagenta.setName("magenta");
		panelMagenta.setBackground(Color.MAGENTA);
		panelMagenta.setBounds(347, 179, 46, 39);
		this.getContentPane().add(panelMagenta);

		JPanel panelCyan = new JPanel();
		panelCyan.setName("cyan");
		panelCyan.setBackground(Color.CYAN);
		panelCyan.setBounds(403, 179, 46, 39);
		this.getContentPane().add(panelCyan);

		panelYellow.addMouseListener(mouseL);
		panelYellow.setTransferHandler(new TransferHandler("name"));

		panelBlue.addMouseListener(mouseL);
		panelBlue.setTransferHandler(new TransferHandler("name"));

		panelRed.addMouseListener(mouseL);
		panelRed.setTransferHandler(new TransferHandler("name"));

		panelGreen.addMouseListener(mouseL);
		panelGreen.setTransferHandler(new TransferHandler("name"));

		panelBlack.addMouseListener(mouseL);
		panelBlack.setTransferHandler(new TransferHandler("name"));

		panelPink.addMouseListener(mouseL);
		panelPink.setTransferHandler(new TransferHandler("name"));

		panelMagenta.addMouseListener(mouseL);
		panelMagenta.setTransferHandler(new TransferHandler("name"));

		panelCyan.addMouseListener(mouseL);
		panelCyan.setTransferHandler(new TransferHandler("name"));

		JButton btnAdd = new JButton("Добавить");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				r = true;
				dispose();
			}
		});
		btnAdd.setBounds(27, 133, 89, 23);
		this.getContentPane().add(btnAdd);

		JButton btnNO = new JButton("Отмена");
		btnNO.setBounds(27, 187, 89, 23);
		this.getContentPane().add(btnNO);
		btnNO.addActionListener((ActionEvent e) -> {
			r = false;
			dispose();
		});
	}

	public Interface getGit() {
		return git;
	}

	public void draw(JPanel panel, Interface git) {
		if (git != null) {
			Graphics gr = panel.getGraphics();
			gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			git.setPos(35, 25);
			git.draw(gr);
		}
	}

	public static Color selectColor(String s) {
		switch (s) {
		case "yellow":
			return Color.yellow;
		case "blue":
			return Color.blue;
		case "red":
			return Color.red;
		case "green":
			return Color.green;
		case "black":
			return Color.black;
		case "pink":
			return Color.pink;
		case "magenta":
			return Color.magenta;
		case "cyan":
			return Color.cyan;
		}

		return null;
	}

}