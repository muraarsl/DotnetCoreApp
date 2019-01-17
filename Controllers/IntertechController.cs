using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreSample.Models;
using CoreSample.Models.Repository;

namespace CoreSample.Controllers
{
    [Route("api/intertech")]
    [ApiController]
    public class IntertechController : ControllerBase
    {
        private readonly IDataRepository<User> _dataRepository;
 
        public IntertechController(IDataRepository<User> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET api/values
        // GET api/values
        [HttpGet]
        [Route("murat")]
        public ActionResult<string> Get()
        {
            return "Interetec e hoşgeldin";
        }

        [HttpGet]
        [Route("user")]
        public ActionResult<User> Get(long id)
        {
            return _dataRepository.Get(id);
        }

        [HttpPost]
        public UserModel Post([FromBody] UserModel userModel)
        {
             User req = new User{
                 Username = userModel.Username,
                 Email = userModel.Email
             };
            _dataRepository.Add(req);
            return userModel;
        }
    }
}
