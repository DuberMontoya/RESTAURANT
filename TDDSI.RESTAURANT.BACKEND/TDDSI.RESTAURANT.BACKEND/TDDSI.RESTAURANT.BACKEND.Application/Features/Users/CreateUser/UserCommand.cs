using System.ComponentModel.DataAnnotations;
using TDDSI.RESTAURANT.BACKEND.Application.Messaging;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.Users.CreateUser;
public record UserCommand(
    [Required] string FirstName
    , string? SecondName
    , [Required] string SurName
    , string? SecondSurName
    ) : ICommand<UserCommandResponse>;
