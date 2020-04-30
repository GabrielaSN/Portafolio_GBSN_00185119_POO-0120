package com.GBSN.x00185119;

public class Libro {

    private String ISBN;
    private String nombre;
    private int pags;

    public Libro (String ISBN, String nom, int pags){
        ISBN = ISBN;
        nombre= nom;
        pags = pags;
    }

    public int getPags() {
        return pags;
    }

    public String getNom() {
        return nombre;
    }

    public String getISBN() {
        return ISBN;
    }



    @Override
    public String toString() {
        String codigo = ISBN;
        String name = nombre;
        int paginas = pags;
        return codigo + ": " + name + " ("+ paginas + ").";

    }

}

