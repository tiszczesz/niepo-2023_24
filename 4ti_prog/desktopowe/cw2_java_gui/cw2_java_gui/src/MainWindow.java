import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.time.LocalDate;


public class MainWindow extends JFrame {
    private JButton button1;
    private JPanel jPanel1;
    private JLabel jLabel1;
    private JTextField textField1;
    private JButton changeLabelButton;
    private JButton wyjścieButton;
    private JButton pokażDatęButton;

    public MainWindow()
    {
        setTitle("Pierwsza App GUI");
        setContentPane(jPanel1);
        setSize(400,400);
        setLocationRelativeTo(null);
        setVisible(true);
        button1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                jLabel1.setText("Hello from SWING GUI");
            }
        });
        changeLabelButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(textField1.getText().trim().isEmpty()){
                    JOptionPane.showMessageDialog(jPanel1,"Brak danych");
                    return;
                }
                jLabel1.setText(textField1.getText());
            }
        });
        wyjścieButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(0);
            }
        });
        pokażDatęButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JOptionPane.showMessageDialog(
                        jPanel1,"Dzisiaj mamy: "+ LocalDate.now());
            }
        });
    }
    public static void main(String[] args){
        new MainWindow();
    }
}
