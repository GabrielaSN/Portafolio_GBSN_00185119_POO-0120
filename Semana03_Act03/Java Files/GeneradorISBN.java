package com.GBSN.x00185119;

public class GeneradorISBN{
    private static int cont=0;

    private GeneradorISBN(){

    }

    public static int nuevoISBN(){
        cont++;
        return cont;
    }
}

