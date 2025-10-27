using CrystalDecisions.CrystalReports.Engine;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Super
{
    internal class GenerarReporte
    {
        string connectionString = "Host=localhost;Port=5432;Database=practicasuper;Username=admin;Password=Santos01";
        public ReportDocument CrearReporte()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string Query = @"SELECT
                        c.id AS id,
                        c.nombre AS nombre,
                        c.apellido AS apellido,
                        p.id AS id_producto,
                        p.nombre AS nombre_producto,
                        p.marca,
                        vp.cantidad
                        FROM clientes c
                        INNER JOIN compras_clientes cc ON c.id = cc.id_cliente
                        INNER JOIN ventas v ON cc.id_venta = v.id
                        INNER JOIN ventas_productos vp ON v.id = vp.id_venta
                        INNER JOIN productos p ON vp.id_producto = p.id;";

                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(Query, connection);

                    DataSetInforme ds = new DataSetInforme();
                    dataAdapter.Fill(ds, "Cliente");

                    ReportDocument reporte = new ReportDocument();

                    reporte.Load(@"C:\\Users\\Gabriel Alanis\\source\\repos\\Practica Super\\Practica Super\\CrystalReport1.rpt");
                    
                    reporte.SetDataSource(ds.Tables["Cliente"]);
                    return reporte;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al generar el reporte: " + ex.Message);
                }
            }
        }
    }
}
