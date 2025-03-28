﻿using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Course.Core.Security
{
	public class JwtConfig
	{
		public string SecretKey { get; set; }
		public int Expiration { get; set; }
		public string Issuer { get; set; }
		public string Audience { get; set; }
	}
}

