﻿using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace SpecFlowTrelloTests.Client
{
    public interface IRequest
    {
        RestRequest GetRequest();

    }
}
