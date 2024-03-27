namespace cw2_razor;

public class PrimaryNumbers
{
    private bool isPrimal(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if(number % i == 0) return false;
        }
        return true;
    }
    public List<int> GetPrimals(int limit){
        List<int> primals = new();
        
        int number = 2;
        while(primals.Count<limit){
            if(isPrimal(number)){
                primals.Add(number);
            }
            number++;
        }
        return primals;
    }
}
