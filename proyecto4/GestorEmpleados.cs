using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SistemaEmpleados
{
    public class GestorEmpleados
    {
        private List<Empleado> listaEmpleados;

        public GestorEmpleados()
        {
            listaEmpleados = new List<Empleado>();
            CargarDatosEjemplo();
        }

        private void CargarDatosEjemplo()
        {
            AgregarEmpleado(new Empleado
            {
                IdEmpleado = "EMP001",
                Nombre = "María García",
                Departamento = "Recursos Humanos",
                Cargo = "Analista de RRHH",
                FechaInicio = new DateTime(2020, 3, 15),
                Salario = 45000m,
                Estado = true
            });

            AgregarEmpleado(new Empleado
            {
                IdEmpleado = "EMP002",
                Nombre = "Carlos Rodríguez",
                Departamento = "Tecnología",
                Cargo = "Desarrollador Junior",
                FechaInicio = new DateTime(2021, 7, 1),
                Salario = 55000m,
                Estado = true
            });

            AgregarEmpleado(new Empleado
            {
                IdEmpleado = "EMP003",
                Nombre = "Ana Martínez",
                Departamento = "Ventas",
                Cargo = "Ejecutiva de Ventas",
                FechaInicio = new DateTime(2019, 1, 10),
                Salario = 38000m,
                Estado = false
            });
        }

        public bool AgregarEmpleado(Empleado empleado)
        {
            if (ExisteEmpleado(empleado.IdEmpleado))
            {
                return false;
            }

            listaEmpleados.Add(empleado);
            return true;
        }

        public List<Empleado> ObtenerTodos()
        {
            return new List<Empleado>(listaEmpleados);
        }

        public Empleado BuscarPorId(string id)
        {
            return listaEmpleados.FirstOrDefault(e =>
                e.IdEmpleado.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public bool ActualizarEmpleado(Empleado empleadoActualizado)
        {
            Empleado existente = BuscarPorId(empleadoActualizado.IdEmpleado);

            if (existente == null)
            {
                return false;
            }

            existente.Nombre = empleadoActualizado.Nombre;
            existente.Departamento = empleadoActualizado.Departamento;
            existente.Cargo = empleadoActualizado.Cargo;
            existente.FechaInicio = empleadoActualizado.FechaInicio;
            existente.Salario = empleadoActualizado.Salario;
            existente.Estado = empleadoActualizado.Estado;

            return true;
        }

        public bool EliminarEmpleado(string id)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                return false;
            }

            listaEmpleados.Remove(empleado);
            return true;
        }

        public bool ExportarCSV(string rutaArchivo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("ID,Nombre,Departamento,Cargo,Fecha Inicio,Salario,Estado,Tiempo en Empresa,AFP,ARS,ISR,Salario Neto");

                foreach (Empleado emp in listaEmpleados)
                {
                    string linea = string.Format(
                        "\"{0}\",\"{1}\",\"{2}\",\"{3}\",{4},{5},\"{6}\",\"{7}\",{8},{9},{10},{11}",
                        emp.IdEmpleado,
                        emp.Nombre,
                        emp.Departamento,
                        emp.Cargo,
                        emp.FechaInicio.ToString("dd/MM/yyyy"),
                        emp.Salario,
                        emp.EstadoTexto,
                        emp.TiempoEnEmpresa,
                        emp.AFP,
                        emp.ARS,
                        emp.ISR,
                        emp.SalarioNeto
                    );

                    sb.AppendLine(linea);
                }

                File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ExisteEmpleado(string id)
        {
            return listaEmpleados.Any(e =>
                e.IdEmpleado.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public int TotalEmpleados => listaEmpleados.Count;
    }
}