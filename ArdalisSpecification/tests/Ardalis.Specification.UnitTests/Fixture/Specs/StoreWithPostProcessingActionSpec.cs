﻿using Ardalis.Specification.UnitTests.Fixture.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ardalis.Specification.UnitTests.Fixture.Specs
{
    public class StoreWithPostProcessingActionSpec : Specification<Store>
    {
        public StoreWithPostProcessingActionSpec()
        {
            Query.PostProcessingAction(x => x);
        }
    }
}