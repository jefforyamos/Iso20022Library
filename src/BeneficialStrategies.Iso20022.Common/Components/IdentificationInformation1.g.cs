﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IdentificationInformation1.  ISO2002 ID# _QpdKstp-Ed-ak6NoX_4Aeg_1272136822.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide identification information.
/// </summary>
public partial record IdentificationInformation1
{
    #nullable enable
    
    /// <summary>
    /// Account owner that owes an amount of money or to whom an amount of money is due.
    /// </summary>
    public PartyIdentification32? Party { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of a party.
    /// </summary>
    public IAccountIdentification4Choice? Account { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for a party.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification4? Agent { get; init; } 
    
    #nullable disable
}
