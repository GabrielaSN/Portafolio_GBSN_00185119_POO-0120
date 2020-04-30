package com.GBSN.x00185119;

public class Autor {

    private String nom;
    private String correo;
    private char genero;

    public Autor (String nombre, String email, char g){
        nom = nombre;
        correo = email;
        genero = g;
    }

    public String getNom() {
        return nom;
    }

    public String getEmail() {
        return correo;
    }

    public void setCorreo(String correo){
        correo = this.correo;
    }

    public char getGen() {
        return genero;
    }



    
    @Override
    public String toString(){
        String name = nom;
        char gen = genero;
        String mail = correo;
        return name + " (" + gen+"): "+ mail;
    }

}

