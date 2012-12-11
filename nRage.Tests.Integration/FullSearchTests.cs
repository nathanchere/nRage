﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace nRage.Tests.Integration {
    public class FullSearchTests : nRage.Tests.Unit.FullSearchTests
    {
        public override void InitialiseIOC() {
            _ioc = new StandardKernel();
            _ioc.Bind<IRetriever>().To<WebRetriever>();
        }
    }
}
