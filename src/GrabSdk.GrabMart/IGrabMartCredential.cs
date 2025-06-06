﻿using System.Threading.Tasks;

namespace Light.Grab.GrabMart
{
    public interface IGrabMartCredential
    {
        string Environment { get; }

        Task<string> GetAccessToken();
    }
}