﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount50.  ISO2002 ID# _6VQoUeaQEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentificationAndAccount50
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [DataMember]
    public required PartyIdentification38Choice_ Identification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [DataMember]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [DataMember]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [DataMember]
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; } 
    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [DataMember]
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; } 
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [DataMember]
    public CashAccountIdentification5Choice_? TaxAccount { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [DataMember]
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    
    #nullable disable
}
