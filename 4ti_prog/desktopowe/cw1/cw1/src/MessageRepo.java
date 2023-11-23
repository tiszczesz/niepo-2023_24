import java.util.ArrayList;
import java.util.List;

public class MessageRepo {
    public static List<Message> getMessages(){
        List<Message> messages =  new ArrayList<>();
        messages.add(new Message("Adam","Badam"));
        messages.add(new Message("Roman","Goman"));
        messages.add(new Message("Daniela","Badam"));
        messages.add(new Message("Anna","Wanna"));
        return  messages;
    }
}
