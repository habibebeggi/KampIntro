using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager: IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(" Gamer saved!");
            }
            else
            {
                Console.WriteLine("Verification failed! Registration failed!");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration has been deleted!");
        }
        public void Update()
        {
            Console.WriteLine("Registration has been updated!");
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
    

    
}
