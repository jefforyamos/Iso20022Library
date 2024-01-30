﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument12.  ISO2002 ID# _SdZNhdp-Ed-ak6NoX_4Aeg_70923680.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument12
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required ISecurityIdentification3Choice Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    
    #nullable disable
}
