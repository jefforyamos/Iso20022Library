﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IdentificationInformation2.  ISO2002 ID# _tpQTY1kyEeGeoaLUQk__nA_1045933986.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification information.
/// </summary>
public partial record IdentificationInformation2
{
    #nullable enable
    
    /// <summary>
    /// Account owner that owes an amount of money or to whom an amount of money is due.
    /// </summary>
    public PartyIdentification43? Party { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of a party.
    /// </summary>
    public IAccountIdentification4Choice? Account { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for a party.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; } 
    
    #nullable disable
}
