﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RelatedCustodianMessageDetailsSD1.  ISO2002 ID# _1WNFoTL3EeKU9IrkkToqcw_735116614.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides selected corporate action events message details extracted from the related custodian messages received.
/// </summary>
public partial record RelatedCustodianMessageDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// Reference the CAEV value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    public required IsoMax4AlphaNumericText ReceivedEventType { get; init; } 
    /// <summary>
    /// Reference the CAMV value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    public required IsoMax4AlphaNumericText ReceivedMandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Reference the CORP value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    public required IsoRestrictedFINXMax16Text ReceivedCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Rate that the ISO message was received from the custodian. Applicable to custodian service only.
    /// </summary>
    public required IsoISODate ReceivedDate { get; init; } 
    /// <summary>
    /// Time of day that the ISO message was received from the custodian. Applicable to custodian service only.
    /// </summary>
    public IsoISOTime? ReceivedTime { get; init; } 
    /// <summary>
    /// Reference of the ISO15022 MT message type received from the custodian message. Applicable to custodian service only.
    /// </summary>
    public required IsoExact3NumericText InboundISOMessageType { get; init; } 
    /// <summary>
    /// BIC Code of the recipient of the custodian record on a received message. Applicable to custodian service only.
    /// </summary>
    public required IsoAnyBICIdentifier InboundISOMessageReceiverBIC { get; init; } 
    /// <summary>
    /// Sender related reference from the received custodian message. Applicable to custodian service only.
    /// </summary>
    public required IsoRestrictedFINXMax16Text ReceivedRelatedReference { get; init; } 
    /// <summary>
    /// Sender SEME from received custodian message. Applicable to custodian service only.
    /// </summary>
    public required IsoRestrictedFINXMax16Text ReceivedSenderMessageReference { get; init; } 
    /// <summary>
    /// BIC Code of the sender of the custodian record on a received message. Applicable to custodian service only.
    /// </summary>
    public required IsoAnyBICIdentifier InboundISOMessageSenderBIC { get; init; } 
    
    #nullable disable
}
