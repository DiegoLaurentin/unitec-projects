import java.util.Scanner;
public class Homework_III_4 {

    /*Realice un programa que lea la edad de varios (n) niños
    y obtenga lo siguiente:

    Preescolar: 3 - 5 años
    Primaria: 6 - 11 años
    Bachiller: 12 - 17 años

    PREGUNTAS:

    1-. ¿Cuántos son de Preescolar?
    2-. ¿Cuántos son de Primaria?
    3-. ¿Cuántos son de Bachillerato?
    4-. Total de niños procesados.

     */
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int edad, preescolar = 0, primaria = 0, bachillerato = 0, total;
        int c = 0, n = 0;
        System.out.print("¿Cuántos niños desea ingresar? ");
        total = Integer.valueOf(sc.nextLine());
        System.out.println("Ingrese la edad del estudiante");

        while (c < total) {
            System.out.print("Edad: ");
            edad = Integer.valueOf(sc.nextLine());

            if (edad >= 3 & edad <= 17) {

                if (edad >= 3 && edad <= 5) {
                    preescolar++;
                } else if (edad >= 6 && edad <= 11) {
                    primaria++;
                } else if (edad >= 12 && edad <= 17) {
                    bachillerato++;
                }
            } else {
                System.out.println("La edad que indicó no es válida.");
                System.out.println("---------------------------------");
                c--;
            }
            c++;
            // System.out.println("niño " + c);
        }

        System.out.println("Estudiantes en Preescolar es: " + preescolar);
        System.out.println("Estudiantes en primaria es: " + primaria);
        System.out.println("Estudiantes en Preescolar es: " + bachillerato);
        System.out.println("---------------------------------");
        System.out.println("Total de estudiantes ingresados: " + total);

    }

}
