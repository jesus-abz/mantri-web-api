using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mantri_web_api.Modules;
using mantri_web_api.Dependencies;
using System.Data.SqlClient;
using System;

namespace mantri_web_api.Controllers
{
    [Route("mantri/[controller]")]
    [ApiController]
    public class MantriController : IMantri
    {
        List<Mantri> listOfMantri => new List<Mantri>

        string connectionstring = @"data source=DESKTOP-0P99JQ4\SQLEXPRESS; initial catalog=db_mantri; user id=mantri; password=mantri41";
        {
            new Mantri
            {
                Nombre = "Rinoserone",
                Elementomain = "Crayea",
                Fase = 1,
                Clase1 = "Terrestre"
            },
            new Mantri
            {
                Nombre = "Socnio",
                Elementomain = "Yuxdilia",
                Fase = 1,
                Clase1 = "Levitador"
            },
        };

        [HttpGet("{id}")]

        public Mantri GetMantri(int id)
        {
            return listOfMantri[id];
        }

        [HttpGet]
        public List<Mantri> GetMantriList()
        {
            List<Mantri> listOfMantri = new List<Mantri>();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from dbo.tpl_mantri", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while()
            {
                Mantri mantri = new Mantri
                {
                    Id = reader.GetInt64(reader.GetOrdinal("id"))
                };
                listOfMantri.Add(mantri);
            }

            conn.Close();
            return listOfMantri;
        }
    }
}