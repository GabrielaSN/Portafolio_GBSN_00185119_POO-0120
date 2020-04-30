//Gabriela Beatriz Solorzano Nuila 00185119

package com.GBSN.x00185119;
import java.util.Scanner;
import java.util.ArrayList;


public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        ArrayList<Libro> books = new ArrayList<>();
        ArrayList<Autor> autors = new ArrayList<>();


        System.out.println("-Biblioteca-");
        System.out.println(" ");
        boolean on = true;

        do{
            switch (printMenu()){
                case 1:
                    System.out.println("\nAgregando un Libro nuevo");
                    String nombre = libroNombre();
                    int pags = libroPags();
                    books.add(new Libro(nombre, pags));
                    break;

                case 2:
                    System.out.println("\nQuitar un libro");
                    books.forEach(a-> System.out.println(a.toString()));
                    System.out.print("Incerte el ISBN de libro a quitar: ");
                    int code = scan.nextInt(); scan.nextLine();
                    int pos=0;
                    for (int i =0; i < books.size(); i++){
                        if (books.get(i).getISBN() == code){
                            pos = i;
                        }
                    }
                    books.remove(pos);
                    System.out.println("\n Se eliminó el libro \n");
                    break;

                case 3:
                    System.out.println("\nMostrar Catálogo de libros");
                    books.forEach(b-> System.out.println(b.toString()));
                    break;

                case 4:
                    System.out.println("\n Agregar un autor");
                    String name = autorNom();
                    String mail = autorCorreo();
                    char genero = autorGenero();
                    autors.add(new Autor(name, mail, genero));
                    break;

                case 5:
                    System.out.println("\nQuitar Autor");
                    autors.forEach(b-> System.out.println(b.toString()));
                    System.out.print("Nombre del autor a eliminar: ");
                    String n = scan.nextLine();
                    int p=0;
                    for (int i =0; i < autors.size(); i++){
                        if (autors.get(i).getNom().equals(n)){
                            p = i;
                        }
                    }
                    autors.remove(p);
                    System.out.println("\n El autor ha sido eliminado \n");
                    break;

                case 6:
                    System.out.println("\nMostrar Autores");
                    autors.forEach(c-> System.out.println(c.toString()));
                    break;

                case 7:
                    System.out.println("Hasta pronto...");
                    on = false;
                    break;
                default:
                    System.out.println("Invalido Error!!");
            }
        }while(on);


    }

    public static int printMenu(){
        Scanner scan = new Scanner(System.in);
        int x=0;
        System.out.println("\n");
        System.out.println("    MENU :");
        System.out.println("1- Agregar un Libro");
        System.out.println("2- Eliminar un Libro ");
        System.out.println("3- Lista de Libros");
        System.out.println("4- Agregar un Autor");
        System.out.println("5- Eliminar un Autor");
        System.out.println("6- Lista de autores");
        System.out.println("7- Terminar");
        System.out.print("Qué desea hacer?: ");
        x= scan.nextInt(); scan.nextLine();
        return x;
    }


    public static String autorNom(){
        Scanner scan = new Scanner(System.in);
        System.out.print("Nombre: ");
        return scan.nextLine();
    }

    public static String autorCorreo(){
        Scanner scan = new Scanner(System.in);
        String mail;
        boolean Ok = false;
        do {
            System.out.print("correo: ");
            mail = scan.nextLine();
            int i = mail.indexOf('@');
            if( i == -1){
                System.out.println("El mail no contiene '@', ingreselo de nuevo!");
            }
            else{
                Ok = true;
            }

        }while(!Ok);

        return mail;
    }

    public static char autorGenero(){
        Scanner scan = new Scanner(System.in);
        char g;
        boolean a = false;
        do {
            System.out.print("Genero ('m' o 'f'): ");
            g = scan.next().charAt(0);
            if( g == 'm' || g== 'f'){
                a=true;
            }
            else{
                System.out.println("Error! ingrese m o f");
            }

        }while(!a);

        return g;
    }


    public static String libroNombre(){
        Scanner scan = new Scanner(System.in);
        System.out.print("Nombre del libro: ");
        return scan.nextLine();
    }

    public static String libroISBN (){
        Scanner scan = new Scanner(System.in);
        System.out.print("ISBN: ");
        return scan.nextLine();
    }

    public static int libroPags(){
        Scanner scan = new Scanner(System.in);
        System.out.print("Páginas?: ");
        return scan.nextInt();
    }

}