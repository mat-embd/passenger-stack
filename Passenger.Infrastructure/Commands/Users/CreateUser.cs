namespace Passenger.Infrastructure.Commands.Users
{
    public class CreateUser : ICommand
    {
        public string Email { get;set;}
        public string Passowrd { get;set;}
        public string Username { get;set;}
    }
}