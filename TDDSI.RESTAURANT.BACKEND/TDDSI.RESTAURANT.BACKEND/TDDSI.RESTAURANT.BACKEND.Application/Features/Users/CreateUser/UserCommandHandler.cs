﻿using TDDSI.RESTAURANT.BACKEND.Application.Messaging;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;
using TDDSI.RESTAURANT.BACKEND.Domain.Users;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.Users.CreateUser;
internal sealed class UserCommandHandler(
    UserService userService
) : ICommandHandler<UserCommand, UserCommandResponse> {

    public async Task<Result<UserCommandResponse>> Handle( UserCommand request
        , CancellationToken cancellationToken
    ) {
        Guid id = await userService
            .CreateUserAsync(
                User.Create(
                    request.FirstName
                    , request.SecondName
                    , request.SurName
                    , request.SecondSurName
                )
                , cancellationToken
            );

        return new UserCommandResponse( id );
    }
}
