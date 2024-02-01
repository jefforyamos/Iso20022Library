﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAuditTrailReport4.  ISO2002 ID# _Ptf-NZJKEeuAlLVx8pyt3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report information about securities reference data.
/// </summary>
public partial record SecuritiesAuditTrailReport4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the returned securities reference data or error information.
    /// </summary>
    public required AuditTrailOrBusinessError6Choice_ SecuritiesAuditTrailOrError { get; init; } 
    /// <summary>
    /// Period in dates for which the audit trail is provided.
    /// </summary>
    public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
    /// <summary>
    /// Identifies the securities for which the audit trail is provided.
    /// </summary>
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    
    #nullable disable
}
