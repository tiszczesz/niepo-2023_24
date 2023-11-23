
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        //Message msg = new Message("Antoni","Małecki");
        List<Message> messages = MessageRepo.getMessages();
        for (Message msg : messages   ) {
            System.out.println(msg);
        }


       // cw1();
    }

    private static void cw1() {
        System.out.println("Witaj 4TI");
        Main2 m2 = new Main2();
        Scanner sc = new Scanner(System.in);
        System.out.print("Podaj a: ");
        int a = sc.nextInt();
        System.out.println(m2.GetA());
        System.out.println("a = "+a);
    }
}
class Main2{
    protected int a = 12;
    public int GetA(){
        return a;
    }
}