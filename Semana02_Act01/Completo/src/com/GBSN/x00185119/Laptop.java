package com.GBSN.x00185119;

public class Laptop {

    private String marca;
    private int memoria;
    private int tamanio;


    // constructor con parámetros
    public Laptop(String pmarca, int pmemoria, int ptamanio) {
        this.marca = pmarca;
        this.memoria = pmemoria;
        this.tamanio = ptamanio;
    }

    //constructor vacio
    public Laptop(){

    }

    // hacer descargas
    public void descargas(String aplicacion){
        System.out.println("Decargando "+aplicacion);
    }

    //finaliza descarga
    public void finalizarDescarga(){
        System.out.println("Descargada con éxito");
    }


    public void Lap(){
        System.out.println(String.format("Marca: %s", marca));
        System.out.println(String.format("GB de memoria: %s", memoria));
        System.out.println(String.format("Tamaño pulgadas: %s", tamanio));
    }


    public String getMarca() {
        return marca;
    }
    public void setMarca(String marca) {
        this.marca = marca;
    }
    public int getMemoria() {
        return memoria;
    }
    public void setMemoria(int memoria) {
        this.memoria = memoria;
    }
    public int getTamanio() {
        return tamanio;
    }
    public void setTamanio(int tamanio) {
        this.tamanio = tamanio;
    }
}
