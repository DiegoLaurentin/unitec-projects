import java.util.Scanner;

public class MainCode {

    /*
    ACTIVIDAD:
    1.- LEER EL NOMBRE DE UN ESTUDIANTE
    2.- LEER LA NOTA DE UN ESTUDIANTE
    3.- LEER E IMPRIMIR EL SUELDO DE UN TRABAJADOR, USAR DECIMALES
    4.- LEER E IMPRIMIR EL COSTO DE UN PRODUCTO, USAR DECIMALES
    */

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int accessCode = 1234;
        int permissionCode;
        int response;

        do {
            System.out.println("Ingrese código de acceso");


            permissionCode = Integer.valueOf(sc.nextLine());

            if (permissionCode == accessCode) {
                System.out.println("Bienvenido");
                System.out.println("Ingrese su pocisión laboral");
                System.out.println("1-. Profesor");
                System.out.println("2-. Trabajador");
                System.out.println("0-. Salir");

                response = Integer.valueOf(sc.nextLine());

                switch (response) {
                    case 0 -> System.out.println("Programa Finalizado");
                    case 1 -> Student();
                    case 2 -> Worker();
                    default -> System.out.println("Ingrese una opción valida");
                }
            }
        } while (permissionCode != accessCode);
    }

    public static void Student() {
        System.out.println("Estás en el menú de profesor");
        Scanner sc = new Scanner(System.in);
        int option;

        do{
            System.out.println("¿Desea ingresar un estudiante?");
            System.out.println("1-. Si");
            System.out.println("2-. No");

            option = Integer.valueOf(sc.nextLine());

            if (option == 1) {

                String name;
                int cedula;
                int calification;
                System.out.println("Ingrese el nombre del estudiante:");
                name = sc.nextLine();
                System.out.println("Ingrese cédula del estudiante (Sin puntos):");
                cedula = Integer.valueOf(sc.nextLine());
                System.out.println("Ingrese nota del estudiante:");
                calification = Integer.valueOf(sc.nextLine());
                System.out.println(name + " C.I. " + cedula + ": " + calification + "Pts");

            } else if (option == 2) {
                System.out.println("El programa ha finalizado");

            } else System.out.println("Ingresaste una opción incorrecta");

        }while (option != 2);
    }
    
    public static void Worker() {
        // 3.- LEER E IMPRIMIR EL SUELDO DE UN TRABAJADOR, USAR DECIMALES
        // 4.- LEER E IMPRIMIR EL COSTO DE UN PRODUCTO, USAR DECIMALES

        int option;
        Scanner sc = new Scanner(System.in);

        do {
            System.out.println("Estás en el menú de trabajador");
            System.out.println("¿Deseas ingresas un trabajador o producto?");
            System.out.println("1-. Ingresar trabajador.");
            System.out.println("2-. Ingresar producto.");
            System.out.println("0-. Salir.");

            option = Integer.valueOf(sc.nextLine());

            if (option == 1) {
                String workerName;
                int cedula;
                double sueldo;

                System.out.println("Ingrese el nombre del trabajador:");
                workerName = sc.nextLine();
                System.out.println("Ingrese cédula del trabajador (Sin puntos):");
                cedula = Integer.valueOf(sc.nextLine());
                System.out.println("Ingrese sueldo del trabajador:");
                sueldo = Double.valueOf(sc.nextLine());

                System.out.println("Usted ha ingresado a " + workerName + ", cuya cédula es C.I. " + cedula + ". Y posee un sueldo de: " + sueldo + "Bs.");


            } else if (option == 2){
                String productName;
                double productCost;

                System.out.println("Ingrese nombre del producto:");
                productName = sc.nextLine();
                System.out.println("Ingrese el costo del producto:");
                productCost = Double.valueOf(sc.nextLine());

                System.out.println("Nombre del producto: " + productName);
                System.out.println("Costo del producto: " + productCost + "Bs.");

            }


        } while (option != 0);
    }


}
