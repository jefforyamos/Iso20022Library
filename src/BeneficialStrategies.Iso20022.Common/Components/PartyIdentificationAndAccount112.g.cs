﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount112.  ISO2002 ID# _E3Yeqx5gEeWE3PufGMdJ3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount112
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification94Choice Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public ICashAccountIdentification5Choice? CashAccount { get; init; } 
    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    public ICashAccountIdentification5Choice? ChargesAccount { get; init; } 
    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    public ICashAccountIdentification5Choice? CommissionAccount { get; init; } 
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    public ICashAccountIdentification5Choice? TaxAccount { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    
    #nullable disable
}
