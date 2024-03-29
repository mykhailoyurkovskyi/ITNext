﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Shop.MVC.Controllers
{
    public abstract class BaseController : Controller
    {
        private IMediator? _mediator;
        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
