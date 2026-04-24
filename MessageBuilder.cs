using System;
using System.Collections.Generic;
using System.Text;

namespace VsSandbox
{
    internal class MessageBuilder
    {
        public string BuildMessage(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Гость";
            }

            return $"Привет, {name}!";
        }
    }
}
