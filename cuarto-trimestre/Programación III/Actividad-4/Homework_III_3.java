import java.util.Scanner;

public class Homework_III_3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int edad, preescolar = 0, primaria = 0, bachillerato = 0, total = 0;
        int n = 0;

        System.out.println("Ingrese la edad del estudiante, si desea culminar, ingrese 0. ");

        do {
            System.out.print("Edad: ");
            edad = Integer.valueOf(sc.nextLine());

            if (edad >= 3 & edad <= 17) {

                if (edad >= 3 && edad <= 5) {
                    preescolar++;
                    total++;
                } else if (edad >= 6 && edad <= 11) {
                    primaria++;
                    total++;
                } else if (edad >= 12 && edad <= 17) {
                    bachillerato++;
                    total++;
                }

            } else if (edad == 0){

                System.out.println("Estudiantes en Preescolar es: " + preescolar);
                System.out.println("Estudiantes en primaria es: " + primaria);
                System.out.println("Estudiantes en Preescolar es: " + bachillerato);
                System.out.println("---------------------------------");
                System.out.println("Total de estudiantes ingresados: " + total);

            } else {
                System.out.println("La edad que indicó no es válida.");
                System.out.println("---------------------------------");
            }

        } while (edad != 0);

    }
}
