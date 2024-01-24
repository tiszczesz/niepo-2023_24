import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.sql.SQLException;
import java.util.List;

public class MainWindow extends JFrame {

    private JTable table1;
    private JPanel jPanel;
    private List<Person> people;

    public MainWindow()  {
        setTitle("Aplikacja");
        setContentPane(jPanel);
        setSize(600,600);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
        JScrollPane scrollPane = new JScrollPane();
        String[] columnNames = {"Imię", "Nazwisko"};
        DefaultTableModel model = new DefaultTableModel(columnNames,0);
       // IRepository repo = new FakeRepo();
        IRepository repo = new MySqlRepo();
        try {
            people = repo.getPersons();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null,"Błąd odczytu z DB");
        }
        for (Person person : people) {
            Object[] row = {person.getFirstName(), person.getLastName()};
            model.addRow(row);
        }
        table1.setModel(model);


    }

    public static void main(String[] args) {
        new MainWindow();

    }
}
