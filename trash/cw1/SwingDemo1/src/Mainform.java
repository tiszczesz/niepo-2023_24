import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Mainform extends JFrame {
    private JPanel panelMain;
    private JTextField firstNameTextField;
    private JTextField lastNametextField;
    private JButton saveButton;
    public static void main(String[] arggs){
      Mainform form = new Mainform();
      form.setContentPane(form.panelMain);
      form.setTitle("Hello");
      form.setSize(300,400);
      form.setVisible(true);
      form.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    public Mainform() {


        saveButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JOptionPane.showMessageDialog(saveButton,"Hello");
            }
        });
    }
}
