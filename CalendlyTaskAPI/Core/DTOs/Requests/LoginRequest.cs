﻿using System.ComponentModel.DataAnnotations;

namespace CalendlyTaskAPI.Core.DTOs.Requests
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
    }
}
