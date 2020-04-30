package com.GBSN.x00185119;

public class Libro {

    private int ISBN;
    private String nombre;
    private int pags;

    public Libro (String nom, int pags){
        ISBN = GeneradorISBN.nuevoISBN();
        nombre= nom;
        pags = pags;
    }

    public int getISBN() {
        return ISBN;
    }
    public String getNombre() {
        return nombre;
    }
    public int getPaginas() {
        return pags;
    }

    @Override
    public String toString() {
        int code = ISBN;
        String name = nombre;
        int paginas = pags;
        return code + ": " + name + " ("+ paginas + ").";

    }


}
