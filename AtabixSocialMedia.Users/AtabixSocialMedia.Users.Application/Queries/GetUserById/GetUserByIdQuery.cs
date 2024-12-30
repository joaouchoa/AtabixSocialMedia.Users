﻿using AtabixSocialMedia.Users.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Application.Queries.GetUserById
{
    public record GetUserByIdQuery(Guid Id) :IRequest<BaseResult<GetUserByIdViewModel>>;
}
