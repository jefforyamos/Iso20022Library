﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalRights1.  ISO2002 ID# _TkUZVdp-Ed-ak6NoX_4Aeg_-552052404.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
public partial record AdditionalRights1
{
    #nullable enable
    
    /// <summary>
    /// Specific rights granted to the shareholders that can be exercised at shareholders meetings (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
    /// </summary>
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on specific rights granted to the shareholders can be found.
    /// </summary>
    public IsoMax256Text? AdditionalRightInformationURLAddress { get; init; } 
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    public DateFormat2Choice_? AdditionalRightDeadline { get; init; } 
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    public DateFormat2Choice_? AdditionalRightMarketDeadline { get; init; } 
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    
    #nullable disable
}
