﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard1.  ISO2002 ID# _SqR5zwEcEeCQm6a_G2yO_w_-584197886.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentCard1
{
    #nullable enable
    
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [DataMember]
    public ContentInformationType2? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [DataMember]
    public PlainCardData1? PlainCardData { get; init; } 
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [DataMember]
    public IsoExact3NumericText? CardCountryCode { get; init; } 
    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [DataMember]
    public IsoExact4NumericText? CardProductProfile { get; init; } 
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CardBrand { get; init; } 
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [DataMember]
    public IsoMax70Text? AdditionalCardData { get; init; } 
    
    #nullable disable
}
