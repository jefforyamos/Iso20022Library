﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalRights1.  ISO2002 ID# _TkUZVdp-Ed-ak6NoX_4Aeg_-552052404.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
[IsoId("_TkUZVdp-Ed-ak6NoX_4Aeg_-552052404")]
[DisplayName("Additional Rights")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalRights1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalRights1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalRights1( AdditionalRightCode1Choice_ reqAdditionalRight )
    {
        AdditionalRight = reqAdditionalRight;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specific rights granted to the shareholders that can be exercised at shareholders meetings (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
    /// </summary>
    [IsoId("_TkUZVtp-Ed-ak6NoX_4Aeg_1606874728")]
    [DisplayName("Additional Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRght")]
    #endif
    [IsoXmlTag("AddtlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    #else
    public AdditionalRightCode1Choice_ AdditionalRight { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on specific rights granted to the shareholders can be found.
    /// </summary>
    [IsoId("_TkUZV9p-Ed-ak6NoX_4Aeg_-990597867")]
    [DisplayName("Additional Right Information URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtInfURLAdr")]
    #endif
    [IsoXmlTag("AddtlRghtInfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalRightInformationURLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalRightInformationURLAddress { get; init; } 
    #else
    public System.String? AdditionalRightInformationURLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TkUZWNp-Ed-ak6NoX_4Aeg_417772718")]
    [DisplayName("Additional Right Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtDdln")]
    #endif
    [IsoXmlTag("AddtlRghtDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? AdditionalRightDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? AdditionalRightDeadline { get; init; } 
    #else
    public DateFormat2Choice_? AdditionalRightDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TkeKUNp-Ed-ak6NoX_4Aeg_417772749")]
    [DisplayName("Additional Right Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtMktDdln")]
    #endif
    [IsoXmlTag("AddtlRghtMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? AdditionalRightMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? AdditionalRightMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? AdditionalRightMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_TkeKUdp-Ed-ak6NoX_4Aeg_-1317132181")]
    [DisplayName("Additional Right Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtThrshld")]
    #endif
    [IsoXmlTag("AddtlRghtThrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    #else
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; set; } 
    #endif
    
    
    #nullable disable
    
}
