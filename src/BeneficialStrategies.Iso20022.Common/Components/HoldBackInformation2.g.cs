﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HoldBackInformation2.  ISO2002 ID# _i4Ff4TwvEeaFzejt0Yw_3A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about hold back and gating.
/// </summary>
[DataContract]
[XmlType]
public partial record HoldBackInformation2
{
    #nullable enable
    
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    [DataMember]
    public required GateHoldBack1Code Type { get; init; } 
    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    [DataMember]
    public IsoISODate? ExpectedReleaseDate { get; init; } 
    /// <summary>
    /// New identification of the security.
    /// </summary>
    [DataMember]
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// New name of the security.
    /// </summary>
    [DataMember]
    public IsoMax350Text? FinancialInstrumentName { get; init; } 
    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    [DataMember]
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; } 
    /// <summary>
    /// Indicates whether or not this is the final redemption confirmation in the execution of a gated redemption.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? FinalConfirmation { get; init; } 
    
    #nullable disable
}
