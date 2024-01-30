﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitSearchCriteria6.  ISO2002 ID# _FZ5lXW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a limit.
/// </summary>
public partial record LimitSearchCriteria6
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of limit as set by default in the system. The default limit is applicable by the system unless otherwise instructed.
    /// </summary>
    public ILimitType1Choice? DefaultLimitType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    public ILimitType1Choice? CurrentLimitType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    /// <summary>
    /// Actual usage of the limit expressed as an amount.
    /// </summary>
    public IActiveAmountRange3Choice? UsedAmount { get; init; } 
    /// <summary>
    /// Actual usage of the limit expressed as a percentage.
    /// </summary>
    public IPercentageRange1Choice? UsedPercentage { get; init; } 
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    public IActiveAmountRange3Choice? LimitAmount { get; init; } 
    /// <summary>
    /// Range of dates when the limit becomes valid.
    /// </summary>
    public IDateAndPeriod2Choice? LimitValidAsOfDate { get; init; } 
    
    #nullable disable
}
