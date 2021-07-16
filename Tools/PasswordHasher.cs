﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Tools
{
    public class PasswordHasher
    {
        public static byte[] Hashing<T>(T userModel, string password, Func<T, string> saltSelector)
        {
            string salt = saltSelector(userModel);
            string result = salt.Substring(0, salt.Length / 2) + password + salt.Substring(salt.Length / 2);
            //string result = salt[0..^2] + password + salt[0..^2];
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(result));
            }
        }
    }
}
