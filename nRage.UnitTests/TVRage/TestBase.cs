﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Xunit;
using nRage.Clients;

namespace nRage.Tests.Unit.TVRage
{
    public class TestBase
    {        
        protected IKernel _ioc;

        protected TVRageClient client;        

        public virtual void InitialiseIOC(){
            _ioc = new StandardKernel();
            _ioc.Bind<IRetriever>().To<TVRageMockRetriever>();
        }

        public TestBase() { 
            InitialiseIOC();
            client = _ioc.Get<TVRageClient>();
        }       
    }
}