﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PlainCardData7.  ISO2002 ID# _E51JoWiyEeS87LmvcA55sg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensible data associated with the payment card performing the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record PlainCardData7
{
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card, or surrogate of the PAN by a payment token.
    /// </summary>
    [DataMember]
    public required IsoMin8Max28NumericText PAN { get; init; } 
    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN or token.
    /// </summary>
    [DataMember]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [DataMember]
    public IsoMax10Text? EffectiveDate { get; init; } 
    /// <summary>
    /// Expiry date of the card or the payment token expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [DataMember]
    public required IsoMax10Text ExpiryDate { get; init; } 
    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [DataMember]
    public IsoExact3NumericText? ServiceCode { get; init; } 
    /// <summary>
    /// Track issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The track value might be provided by a payment token.
    /// </summary>
    [DataMember]
    public ValueList<TrackData1> TrackData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Name of the cardholder stored on the card.
    /// </summary>
    [DataMember]
    public IsoMax45Text? CardholderName { get; init; } 
    
    #nullable disable
}
