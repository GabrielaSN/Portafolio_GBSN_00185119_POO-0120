package com.GBSN.x00185119;

public class Tablet {

    private String usuario;
    private int aplicaciones;
    private int carga;


    // con parámetros
    public Tablet(String usuario, int aplicaciones, int carga) {
        this.usuario = usuario;
        this.aplicaciones = aplicaciones;
        this.carga = carga;
    }

    //constructor vacio
    public Tablet() {

    }

    // hacer facetime
    public void facetime(String persona) {
        System.out.println("Llamando a " + persona);
    }

    //finaliza facetime
    public void finalizarf() {
        System.out.println("Terminando videollamada...");
    }


    public void Tab() {
        System.out.println(String.format("Usuario: %s", usuario));
        System.out.println(String.format("Cantidad de aplicaciones: %s", aplicaciones));
        System.out.println(String.format("Carga restante: %s", carga));
    }


    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public int getAplicaciones() {
        return aplicaciones;
    }

    public void setAplicaciones(int aplicaciones) {
        this.aplicaciones = aplicaciones;
    }

    public int getCarga() {
        return carga;
    }

    public void setCarga(int carga) {
        this.carga = carga;
    }


}
