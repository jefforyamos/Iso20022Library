﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Terminal4.  ISO2002 ID# _pdn_kaH8EeuiuNcvKhXmNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction
/// </summary>
public partial record Terminal4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    public required TerminalIdentification3 TerminalIdentification { get; init; } 
    /// <summary>
    /// Type of terminal.
    /// </summary>
    public TerminalType1Code? Type { get; init; } 
    /// <summary>
    /// Other type of terminal.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Capabilities of the terminal
    /// </summary>
    public Capabilities2? Capabilities { get; init; } 
    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; } 
    /// <summary>
    /// Geographic location of the terminal.
    /// </summary>
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; } 
    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.
    /// True: The terminal is operated outdoor
    /// False: The terminal is operated indoor
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
    public PointOfInteractionComponent13[] POIComponent { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
