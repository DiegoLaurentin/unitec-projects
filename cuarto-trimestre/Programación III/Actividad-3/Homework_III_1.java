import java.util.Scanner;

public class Homework_III_1 {
    public static void main(String[] args) {

        /* Un negocio lo contrata a usted para realizar un programa que permita ingresar el valor de compra de un
        producto y calcular lo siguiente:
            - Si el pago se efectúa al “contado”, calcular un descuento del 5%
            - Si el pago es con “tarjeta” se incrementa un recargo del 3% al valor de compra.
            - Calcular y visualizar el descuento o recargo según sea el caso y el total a pagar de la compra.
         */

        Scanner sc = new Scanner(System.in);
        String nombre;
        int accessCode = 1234;
        int cedula, permissionCode, response, tipoDePago, counter, option;
        double valorCompra, total, sumCompra = 0;


        do {

            System.out.println("Ingrese código de acceso");
            permissionCode = Integer.valueOf(sc.nextLine());

            if (permissionCode == accessCode) {

                System.out.println("");
                System.out.println("-----------------------");
                System.out.println("");
                System.out.println("Bienvenid@");
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
                        valorCompra = Double.valueOf(sc.nextLine());
                        sumCompra = valorCompra + sumCompra;

                    } while (valorCompra != 0);

                System.out.println("");
                System.out.println("-----------------------");
                System.out.println("Seleccione el tipo de pago");
                System.out.println("1-. De contado");
                System.out.println("2-. Tarjeta");
                tipoDePago = Integer.valueOf(sc.nextLine());

                if (tipoDePago == 1){
                    double descuento;
                    descuento = sumCompra * 0.05;
                    total = sumCompra - descuento;

                    System.out.println("");
                    System.out.println("-----------------------");
                    System.out.println("Factura:");
                    System.out.println("-----------------------");
                    System.out.println("Nombre: " + nombre);
                    System.out.println("Cédula: " + cedula);
                    System.out.println("Monto Bs: " + sumCompra);
                    System.out.println("Descuento 5% Bs: " + descuento);
                    System.out.println("Total Bs: " + total);

                } else if (tipoDePago == 2){
                    double recarga;
                    recarga = sumCompra * 0.03;
                    total = sumCompra + recarga;

                    System.out.println("");
                    System.out.println("-----------------------");
                    System.out.println("Factura:");
                    System.out.println("-----------------------");
                    System.out.println("Nombre: " + nombre);
                    System.out.println("Cédula: " + cedula);
                    System.out.println("Monto Bs: " + sumCompra);
                    System.out.println("Recarga 3% Bs: " + recarga);
                    System.out.println("Total Bs: " + total);

                }else {
                    System.out.println("Tipo de pago no válido");
                }

            }

        } while (permissionCode != accessCode);

    }
}
