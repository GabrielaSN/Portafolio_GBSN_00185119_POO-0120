//Gabriela Beatriz Solorzano Nuila 00185119

package com.GBSN.x00185119;

public class Main {

    public static void main(String[] args) {

        System.out.println(" ");
        System.out.println("Informacion de Tablet");

        Tablet tab = new Tablet();

        tab.setUsuario("Tablet Gabriela Solorzano");
        tab.setAplicaciones(32);
        tab.setCarga(95);

        tab.facetime("Juan S");
        tab.finalizarf();
        System.out.println();
        tab.Tab();

        System.out.println(" ");
        System.out.println("Informacion de Laptop");

        Laptop lap = new Laptop();

        lap.setMarca("Hp");
        lap.setMemoria(16);
        lap.setTamanio(14);

        lap.descargas("Intellij...");
        lap.finalizarDescarga();
        System.out.println();
        lap.Lap();
    }

}




