using Exercise.Exercise2;


public class Program { 
    static void Main(string[] args) { 
        PhoneBook pb= new PhoneBook();

        pb.InsertPhone("Hana", "0123456789");
        pb.InsertPhone("BichThuy", "0213456789");
        pb.InsertPhone("Mary", "0127856789");

        pb.SearchPhone("BichThuy");
        pb.SearchPhone("Nguyen"); // khong tìm thấy

        pb.UpdatePhone("BichThuy", "0987564123");
        pb.SearchPhone("BichThuy");

        pb.Sort();

    }
}
