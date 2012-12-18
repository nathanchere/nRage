﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Xunit;
using nRage.Clients;

namespace nRage.Tests.Unit.TheTVDB
{
    public class TheTVDBClientTestBase
    {        
        protected IKernel _ioc;

        protected TheTVDBClient client;        

        public virtual void InitialiseIOC(){
            _ioc = new StandardKernel();
            _ioc.Bind<IRetriever>().To<MockRetriever>();
        }

        public TheTVDBClientTestBase() { 
            InitialiseIOC();
            client = _ioc.Get<TheTVDBClient>();
        }       
    }
}
