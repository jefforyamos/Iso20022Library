﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charges12.  ISO2002 ID# _NfldERlWEe2Do_UtrNmb2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the charges related to the payment transaction.
/// </summary>
public partial record Charges12
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; } 
    /// <summary>
    /// Defines the type of charges.
    /// </summary>
    public ChargeType3Choice_? Type { get; init; } 
    
    #nullable disable
}
