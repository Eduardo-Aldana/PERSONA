/* Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Objetos

    Nombre del Maestro: Chuc Uc Joel Ivan

    Nombre de la actividad: Actividad 1  El alumno utilizará las API's para programar aplicaciones orientadas a servicios.

    Nombre del alumno: BRAHIM EDUARDO ALDANA CHUC

    Cuatrimestre: 4

    Grupo: A

    Parcial: 2 */


using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        /// Escribe un método en el cual se retorne la información de todas las personas.
        [HttpGet]
        [Route("PersonasBase")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 
        /// Escribe un método en el cual se retorne únicamente el nombre completo de las personas, el correo y el año de nacimiento.
        [HttpGet]
        [Route("ObtenerCampos")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de todas las personas cuyo genero sea Femenino.
        [HttpGet]
        [Route("ObtenerPorgenero")]
        public IActionResult ObtenerGenero()
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerGenero();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de todas las personas cuya edad se encuentre entre los 20 y 30 años.
        [HttpGet]
        [Route("ObternerPorRangoEdad")]
        public IActionResult GetByRangeAge()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de los diferentes trabajos que tienen las personas.
        [HttpGet]
        [Route("TrabjosPerosona")]
        public IActionResult GetDiferences()
        {
            var repository = new PersonRepository();
            var persons = repository.GetDiferences();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de las personas cuyo nombre contenga la palabra ar
        [HttpGet]
        [Route("PersonasAR")]
        public IActionResult GetContains()
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains();
            return Ok(persons);
        } 
        ///Escribe un método que retorna la información de las personas cuyas edades sean 25, 35 y 45 años
         [HttpGet]
         [Route("Edades")]
        public IActionResult GetByAges()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAges();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información ordenas por edad para las personas que sean mayores a 40 años
         [HttpGet]
         [Route("MayorEdad")]
        public IActionResult MayorEdad()
        {
            var repository = new PersonRepository();
            var persons = repository.MayorEdad();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información ordenada de manera descendente para todas las personas de género masculino y que se encuentren entre los 20 y 30 años de edad
         [HttpGet]
         [Route("OrdenarEdades")]
        public IActionResult GetPersonsOrderedDescending()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDescending();
            return Ok(persons);
        }
        /// Escribe un método que retorne la cantidad de personas con género femenino. 
        [HttpGet]
        [Route("GeneroFem")]
        public IActionResult CountFemenino()
        {
            var repository = new PersonRepository();
            var persons = repository.CountFemenino();
            return Ok(persons);
        } 
        /// Escribe un método que retorna si existen personas con el apellido “Shemelt”.
        [HttpGet]
        [Route("ExistePersona")]
        public IActionResult ExistPersona()
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPersona();
            return Ok(persons);
        } 
        //Escribe un método que retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad
         [HttpGet]
         [Route("TomarPersonaEdad")]
        public IActionResult TakePersonAngAge()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePersonAngAge();
            return Ok(persons);
        } 
        ///Escribe un método que omita la información de las primeras 3 personas cuyo puesto de  trabajo sea “Software Consultant”
        [HttpGet]
        [Route("TomarPersona")]
        public IActionResult TakePersona()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePersona();
            return Ok(persons);
        } 
        ///Escribe un método que omita la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
        [HttpGet]
        [Route("OmitaPersona")]
        public IActionResult SkipPersona()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPersona();
            return Ok(persons);
        } 
        ///Escribe un método que omita la información de las primeras 3 personas y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea “Software Consultant”
        [HttpGet]
        [Route("OmitaRetPersona")]
        public IActionResult SkipTakePersona()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePersona();
            return Ok(persons);
        } 
        

    }
}