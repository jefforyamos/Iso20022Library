﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount38.  ISO2002 ID# _K2BzWeaOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount38
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification49Choice_ Identification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; } 
    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; } 
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    public CashAccountIdentification5Choice_? TaxAccount { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    
    #nullable disable
}
