using System.IO;
using System;
using UnityEngine;

public class Inventario{
    private int puntaje;
    private int guantes;
    private int mascarillas;
    private int gemas;
    private int monedas;

    public Inventario()
    {
        puntaje = 0;
        guantes = 0;
        mascarillas = 0;
        try
        {
            TextReader l= new StreamReader("InstanciaInventario.txt");
        }
        catch
        {
            TextWriter linea1 = new StreamWriter("InstanciaInventario.txt");
            linea1.WriteLine("0"); //gemas
            linea1.Close();
            StreamWriter linea2 = File.AppendText("InstanciaInventario.txt");
            linea2.WriteLine("0"); //monedas
            linea2.Close();
        }
        TextReader linea = new StreamReader("InstanciaInventario.txt");
        gemas = Int32.Parse(linea.ReadLine());
        monedas = Int32.Parse(linea.ReadLine());
        linea.Close();
    }
    public void AumentarPuntaje(int cantidad)
    {
        puntaje = puntaje + cantidad;
    }
    public void AumentarGuantes()
    {
        guantes = guantes++;
    }
    public void AumentarMascarillas()
    {
        mascarillas = mascarillas++;
    }
    public void DisminuirGuantes(int cantidad)
    {
        guantes = guantes - cantidad;
    }
    public void DisminuirMascarillas(int cantidad)
    {
        mascarillas = mascarillas - cantidad;
    }
    public void AumentarGemas(int cantidad)
    {
        gemas = gemas + cantidad;
        TextWriter linea1 = new StreamWriter("InstanciaInventario.txt");
        linea1.WriteLine(gemas);
        linea1.Close();
        StreamWriter linea2 = File.AppendText("InstanciaInventario.txt");
        linea2.WriteLine(monedas); //monedas
        linea2.Close();
    }
    public void AumentarMonedas(int cantidad)
    {
        monedas = monedas + cantidad;
        TextWriter linea1 = new StreamWriter("InstanciaInventario.txt");
        linea1.WriteLine(gemas);
        linea1.Close();
        StreamWriter linea2 = File.AppendText("InstanciaInventario.txt");
        linea2.WriteLine(monedas); //monedas
        linea2.Close();
    }
    public void DisminuirMonedas(int cantidad)
    {
        monedas = monedas - cantidad;
        TextWriter linea1 = new StreamWriter("InstanciaInventario.txt");
        linea1.WriteLine(gemas);
        linea1.Close();
        StreamWriter linea2 = File.AppendText("InstanciaInventario.txt");
        linea2.WriteLine(monedas); //monedas
        linea2.Close();
    }
    public void DisminuirGemas(int cantidad)
    {
        gemas = gemas - cantidad;
        TextWriter linea1 = new StreamWriter("InstanciaInventario.txt");
        linea1.WriteLine(gemas);
        linea1.Close();
        StreamWriter linea2 = File.AppendText("InstanciaInventario.txt");
        linea2.WriteLine(monedas); //monedas
        linea2.Close();
    }
    public void MostrarGemas()
    {
        Debug.Log("la cantidad de gemas son: "+gemas);
    }
}
