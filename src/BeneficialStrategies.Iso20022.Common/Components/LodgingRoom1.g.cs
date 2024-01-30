﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LodgingRoom1.  ISO2002 ID# _kVNgxfcTEeiW-auGnDPZIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Room details
/// </summary>
public partial record LodgingRoom1
{
    #nullable enable
    
    /// <summary>
    /// Type of room (for example, club/lounge level room). 
    /// </summary>
    public IsoMax35Text? RoomType { get; init; } 
    /// <summary>
    /// Contains the room location information (for example,ocean view, lake view, level, etc.) 
    /// </summary>
    public IsoMax35Text? RoomLocation { get; init; } 
    /// <summary>
    /// Contain the type of bed in room (for example, single, double, king, etc.) 
    /// </summary>
    public IsoMax70Text? BedType { get; init; } 
    /// <summary>
    /// Contains the number of guests in the room. 
    /// </summary>
    public IsoMax3NumericText? GuestsPerRoom { get; init; } 
    /// <summary>
    /// Contains the number of adult guests in the room. 
    /// </summary>
    public IsoMax3NumericText? AdultsInRoom { get; init; } 
    /// <summary>
    /// Contains the number of child guests in the room. 
    /// </summary>
    public IsoMax3NumericText? ChildrenInRoom { get; init; } 
    /// <summary>
    /// Daily rate being charged for the room.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? DailyRoomRate { get; init; } 
    
    #nullable disable
}
