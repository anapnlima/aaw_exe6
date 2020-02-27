using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomaController : ControllerBase
    {
        [HttpPost]
        public AnswerObj Post(ReceivedObj item)
        {
            AnswerObj result = new AnswerObj();
            result.Result = item.Value1 + item.Value2;
            return result;
        }
    }
}
