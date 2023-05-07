import java.util.Scanner;
import java.util.regex.Pattern;

public class Calculator {
    public static void main(String[] args) {
        System.out.println("Welcome to Calc in Java!");
        System.out.println("Type \"exit\" to exit.")

        Scanner scan = new Scanner(System.in);

        while(true){
            try {
                System.out.print(">");
                String in = scan.nextLine();

                if(in.contains("exit")){
                    System.exit(0);
                }

                if (in.contains("+")) {
                    System.out.println(seperateInts(in,"+"));
                } else if (in.contains("-")) {
                    System.out.println(seperateInts(in,"-"));
                } else if (in.contains("/")) {
                    System.out.println(seperateInts(in,"/"));
                }  else if (in.contains("*")) {
                    System.out.println(seperateInts(in,"*"));
                } else if (in.contains("%")) {
                    System.out.println(seperateInts(in,"%"));
                } else {
                    System.out.println("No operator or not supported operator.");
                }
            } catch (Exception e){
                System.out.println("You typed shit." + e);
            }
            
          
        }
    }

    public static int seperateInts(String in, String regex){
        int[] add = {Integer.parseInt(in.split(Pattern.quote(regex))[0]), Integer.parseInt(in.split(Pattern.quote(regex))[1])};

        switch (regex){
            case "+":
                return add[0] + add[1];

            case "-":
                return add[0] - add[1];

            case "/":
                return add[0] / add[1];

            case "*":
                return add[0] * add[1];

            case "%":
                return add[0] % add[1];
        }
        return 0;
    }
}
