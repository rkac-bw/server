﻿using Bit.Core.Enums;
using Bit.Core.Utilities;
using Xunit;

namespace Bit.Core.Test.Utilities;


public class StaticStoreTests
{
    [Fact]
    public void StaticStore_Initialization_Success()
    {
        var plans = StaticStore.Plans;
        Assert.NotNull(plans);
        Assert.NotEmpty(plans);
        Assert.Equal(12, plans.Count());
    }

    [Theory]
    [InlineData(PlanType.EnterpriseAnnually)]
    [InlineData(PlanType.EnterpriseMonthly)]
    [InlineData(PlanType.TeamsMonthly)]
    [InlineData(PlanType.TeamsAnnually)]
    public void StaticStore_GetPlan_Success(PlanType planType)
    {
        var plan = StaticStore.GetPlan(planType);
        Assert.NotNull(plan);
        Assert.Equal(planType, plan.Type);
    }
}
