﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Terminal3.  ISO2002 ID# _e4IxaewNEeiMkKo2clXHdQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction
/// </summary>
public partial record Terminal3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    public TerminalIdentification2? TerminalIdentification { get; init; } 
    /// <summary>
    /// Capabilities of the terminal.
    /// </summary>
    public Capabilities1? Capabilities { get; init; } 
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-2
    /// </summary>
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; } 
    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.
    /// True: The terminal is operated outdoor.
    /// False: The terminal is operated indoor.
    /// </summary>
    public IsoTrueFalseIndicator? OutdoorIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the terminal is operated on- or off-premises at the point of service.
    /// True: The terminal is operated off premises.
    /// False: The terminal is operated on premises.
    /// ISO 8583:93 bit 22-4, ISO 8583:2003 bit 22-3.
    /// </summary>
    public IsoTrueFalseIndicator? OffPremisesIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the transaction was performed on board.
    /// True: The terminal is located on board.
    /// False: The terminal is not located on board.
    /// </summary>
    public IsoTrueFalseIndicator? OnBoardIndicator { get; init; } 
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the transactions.
    /// </summary>
    public PointOfInteractionComponent8? POIComponent { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
