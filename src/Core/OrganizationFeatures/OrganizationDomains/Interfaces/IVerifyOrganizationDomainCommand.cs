﻿using Bit.Core.Entities;

namespace Bit.Core.OrganizationFeatures.OrganizationDomains.Interfaces;

public interface IVerifyOrganizationDomainCommand
{
    Task<OrganizationDomain> VerifyOrganizationDomainAsync(OrganizationDomain organizationDomain);
}
