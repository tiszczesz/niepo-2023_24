import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.util.List;

public class MainWindow extends JFrame {

    private JTable table1;
    private JPanel jPanel;
    private List<Person> people;

    public MainWindow() {
        setTitle("Aplikacja");
        setContentPane(jPanel);
        setSize(600,600);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
        JScrollPane scrollPane = new JScrollPane();
        String[] columnNames = {"Imię", "Nazwisko"};
        DefaultTableModel model = new DefaultTableModel(columnNames,0);
        MyRepo repo = new MyRepo();
        people = repo.getPersons();
        for (Person person : people) {
            Object[] row = {person.getFirstName(), person.getLastName()};
            model.addRow(row);
        }
        table1.setModel(model);
        this.add(scrollPane);
        this.pack();
    }

    public static void main(String[] args) {
        new MainWindow();

    }
}
