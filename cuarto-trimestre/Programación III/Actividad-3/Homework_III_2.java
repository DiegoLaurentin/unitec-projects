import java.util.Scanner;

public class Homework_III_2 {
    public static void main(String[] args) {

        /* Tiendas Don Pepe desea un programa para ingresar por teclado el monto de compra y el día de la
        semana; si el día es martes o jueves, se realizará un descuento del 15% por la compra. Visualizar
        el descuento y el total a pagar por la compra. */

        Scanner sc = new Scanner(System.in);
        String nombre;
        int day, cedula, response, permissionCode, counter, option, accessCode = 1234;
        double totalCompra, montoCompra, descuento, sumaCompra = 0;

        do {

            System.out.println("Ingrese código de acceso");
            permissionCode = Integer.valueOf(sc.nextLine());

            if (permissionCode == accessCode){

                System.out.println("");
                System.out.println("-----------------------");
                System.out.println("");
                System.out.println("Sistema de Tiendas Don Pepe");
                System.out.print("Nombre del cliente: ");
                nombre = sc.nextLine();
                System.out.print("Cédula del cliente: ");
                cedula = Integer.valueOf(sc.nextLine());

                System.out.println("Ingrese el valor de la compra.");
                System.out.println("Coloque 0 para finalizar.");
                System.out.println("");
                System.out.println("-----------------------");

                do {

                    System.out.print("Bs: ");
                    montoCompra = Double.valueOf(sc.nextLine());
                    sumaCompra = montoCompra + sumaCompra;

                } while (montoCompra != 0);

                System.out.println("");
                System.out.println("-----------------------");
                System.out.println("");
                System.out.println("Ingrese el día de la semana:");
                System.out.println("0-. Lunes | 1-. Martes | 2-. Miércoles | 3-. Jueves | 4-. Viernes | 5-. Sábado | 6-. Domingo");
                day = Integer.valueOf(sc.nextLine());

                if (day == 1 || day == 3){
                    descuento = sumaCompra * 0.15;
                    totalCompra = sumaCompra - descuento;

                    System.out.println("");
                    System.out.println("-----------------------");
                    System.out.println("Factura Tiendas Don Pepe:");
                    System.out.println("-----------------------");
                    System.out.println("Nombre: " + nombre);
                    System.out.println("Cédula: " + cedula);
                    System.out.println("Monto Bs: " + sumaCompra);
                    System.out.println("Descuento 15% Bs: " + descuento);
                    System.out.println("Total Bs: " + totalCompra);
                } else {
                    System.out.println("");
                    System.out.println("-----------------------");
                    System.out.println("Factura Tiendas Don Pepe:");
                    System.out.println("-----------------------");
                    System.out.println("Nombre: " + nombre);
                    System.out.println("Cédula: " + cedula);
                    System.out.println("Monto Bs: " + sumaCompra);
                }

            }


        } while (permissionCode != accessCode);



        // option = Integer.valueOf(sc.nextLine());
    }
}
