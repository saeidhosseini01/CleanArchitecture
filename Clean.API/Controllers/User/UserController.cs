using CleanArchitecture.Application.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Clean.API.Controllers.User
{






    [Microsoft.AspNetCore.Components.Route("api/[Controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserRepository userRepository,ILogger<UserController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
                
        }

       public async Task<IActionResult> GetUserByGuid(Guid guid,CancellationToken cancellationToken)
        {
            
            var res=await _userRepository.GetByGuidAsync(guid, cancellationToken);
            return Ok(res);
        }


    }
}
