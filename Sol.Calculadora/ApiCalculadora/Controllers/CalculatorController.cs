namespace ApiCalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //Proceso en Postman:
        //Se ejecuta el programa y se copia la url en postman
        // Ejemplo https://localhost:44362/api/Calculator/Division
        [HttpPost]
        [Route("Add")]//Al tener varias funciones esta es una referencia para el Postman; para que sepa que es esta funcion en especifico
        public int Add([FromHeader] int num_a, [FromHeader] int num_b) //Creamos una funcion; FromHeader = Para recibir desde el Header los valores
        {
            return num_a + num_b;
        }

        [HttpPost]
        [Route("Subtract")]
        public int Subtract([FromHeader] int num_a, [FromHeader] int num_b)
        {
            return num_a - num_b;
        }

        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int num_a, [FromHeader] int num_b)
        {
            return num_a * num_b;
        }

        [HttpPost]
        [Route("Division")]
        public int Division([FromHeader] int num_a,[FromHeader]int num_b)
        {
            return num_a / num_b;
        }
    }
}
