// ============================================================
// ARCHIVO: Empleado.cs
// DESCRIPCIÓN: Clase que representa la estructura de datos
//              de un empleado en el sistema.
// CURSO: Programación 1
// ============================================================

using System;

namespace SistemaEmpleados
{
    /// <summary>
    /// Clase Empleado: Define todos los campos que describe a un empleado.
    /// En programación, una "clase" es como un molde para crear objetos.
    /// Cada objeto creado con esta clase será un empleado diferente.
    /// </summary>
    public class Empleado
    {
        // --------------------------------------------------------
        // PROPIEDADES (campos del empleado)
        // Cada propiedad representa un dato del empleado.
        // "public" significa que se puede acceder desde cualquier parte.
        // --------------------------------------------------------

        /// <summary>ID único del empleado. No puede repetirse.</summary>
        public string IdEmpleado { get; set; }

        /// <summary>Nombre completo del empleado.</summary>
        public string Nombre { get; set; }

        /// <summary>Departamento al que pertenece el empleado.</summary>
        public string Departamento { get; set; }

        /// <summary>Cargo o puesto que ocupa en la empresa.</summary>
        public string Cargo { get; set; }

        /// <summary>Fecha en que el empleado inició en la empresa.</summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>Salario bruto mensual del empleado.</summary>
        public decimal Salario { get; set; }

        /// <summary>Estado del empleado: true = Vigente, false = No Vigente.</summary>
        public bool Estado { get; set; }

        // --------------------------------------------------------
        // PROPIEDADES CALCULADAS (se obtienen automáticamente)
        // Estas no se guardan directamente, sino que se calculan.
        // --------------------------------------------------------

        /// <summary>
        /// Calcula cuántos años y meses lleva el empleado en la empresa.
        /// Compara la FechaInicio con la fecha actual (hoy).
        /// </summary>
        public string TiempoEnEmpresa
        {
            get
            {
                // Obtenemos la fecha de hoy
                DateTime hoy = DateTime.Today;

                // Calculamos los años de diferencia
                int anios = hoy.Year - FechaInicio.Year;

                // Calculamos los meses de diferencia dentro del año
                int meses = hoy.Month - FechaInicio.Month;

                // Si los meses son negativos, ajustamos restando un año
                if (meses < 0)
                {
                    anios--;
                    meses += 12; // Sumamos 12 para que sea positivo
                }

                // Si el día actual es menor que el día de inicio, restamos un mes
                if (hoy.Day < FechaInicio.Day && meses > 0)
                {
                    meses--;
                }

                return $"{anios} año(s) y {meses} mes(es)";
            }
        }

        /// <summary>
        /// Calcula el descuento AFP (Administradora de Fondos de Pensiones).
        /// AFP = 2.87% del salario bruto.
        /// Esto representa el aporte del empleado al fondo de pensiones.
        /// </summary>
        public decimal AFP
        {
            get
            {
                return Math.Round(Salario * 0.0287m, 2);
            }
        }

        /// <summary>
        /// Calcula el descuento ARS (Administradora de Riesgos de Salud).
        /// ARS = 3.04% del salario bruto.
        /// Esto representa el aporte del empleado al seguro de salud.
        /// </summary>
        public decimal ARS
        {
            get
            {
                return Math.Round(Salario * 0.0304m, 2);
            }
        }

        /// <summary>
        /// Calcula el Impuesto Sobre la Renta (ISR) de forma simplificada.
        /// El ISR se calcula primero obteniendo el salario neto (sin AFP ni ARS),
        /// luego aplicando una tabla de tramos según el ingreso anual.
        ///
        /// Tabla ISR simplificada (República Dominicana):
        ///   - Hasta RD$416,220 anuales   → 0%
        ///   - RD$416,220 a RD$624,329    → 15% sobre el excedente
        ///   - RD$624,329 a RD$867,123    → 20% sobre el excedente
        ///   - Más de RD$867,123          → 25% sobre el excedente
        /// </summary>
        public decimal ISR
        {
            get
            {
                // Calculamos el salario neto mensual (quitando AFP y ARS)
                decimal salarioNeto = Salario - AFP - ARS;

                // Convertimos a ingreso anual para aplicar la tabla del ISR
                decimal ingresoAnual = salarioNeto * 12;

                decimal isrAnual = 0;

                // Aplicamos la tabla de ISR por tramos
                if (ingresoAnual <= 416220)
                {
                    // Tramo 1: No paga ISR
                    isrAnual = 0;
                }
                else if (ingresoAnual <= 624329)
                {
                    // Tramo 2: 15% sobre el excedente de RD$416,220
                    isrAnual = (ingresoAnual - 416220) * 0.15m;
                }
                else if (ingresoAnual <= 867123)
                {
                    // Tramo 3: monto fijo del tramo anterior + 20% sobre el excedente
                    isrAnual = (624329 - 416220) * 0.15m + (ingresoAnual - 624329) * 0.20m;
                }
                else
                {
                    // Tramo 4: montos fijos de tramos anteriores + 25% sobre el excedente
                    isrAnual = (624329 - 416220) * 0.15m
                              + (867123 - 624329) * 0.20m
                              + (ingresoAnual - 867123) * 0.25m;
                }

                // Dividimos entre 12 para obtener el ISR mensual y redondeamos
                return Math.Round(isrAnual / 12, 2);
            }
        }

        /// <summary>
        /// Calcula el salario neto final: salario bruto menos AFP, ARS e ISR.
        /// Este es el monto que el empleado recibe en mano.
        /// </summary>
        public decimal SalarioNeto
        {
            get
            {
                return Math.Round(Salario - AFP - ARS - ISR, 2);
            }
        }

        /// <summary>
        /// Devuelve el estado como texto legible: "Vigente" o "No Vigente".
        /// </summary>
        public string EstadoTexto
        {
            get
            {
                return Estado ? "Vigente" : "No Vigente";
            }
        }
    }
}
