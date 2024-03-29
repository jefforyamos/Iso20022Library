﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote14.  ISO2002 ID# _8c6H1fNXEeqRfth943bvEA.
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
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_8c6H1fNXEeqRfth943bvEA")]
[DisplayName("Vote")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vote14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vote14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vote14( System.String reqIssuerLabel )
    {
        IssuerLabel = reqIssuerLabel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_8v8_o_NXEeqRfth943bvEA")]
    [DisplayName("Issuer Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrLabl")]
    #endif
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IssuerLabel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerLabel { get; init; } 
    #else
    public System.String IssuerLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    [IsoId("_hYJhAfNXEeqRfth943bvEA")]
    [DisplayName("Listing Group Resolution Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListgGrpRsltnLabl")]
    #endif
    [IsoXmlTag("ListgGrpRsltnLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ListingGroupResolutionLabel { get; init; } 
    #else
    public System.String? ListingGroupResolutionLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_8v8_pfNXEeqRfth943bvEA")]
    [DisplayName("For")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="For")]
    #endif
    [IsoXmlTag("For")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? For { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? For { get; init; } 
    #else
    public QuantityOrCode1Choice_? For { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_8v8_p_NXEeqRfth943bvEA")]
    [DisplayName("Against")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agnst")]
    #endif
    [IsoXmlTag("Agnst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? Against { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? Against { get; init; } 
    #else
    public QuantityOrCode1Choice_? Against { get; set; } 
    #endif
    
    /// <summary>
    /// Number of abstention votes for one resolution.
    /// </summary>
    [IsoId("_8v8_qfNXEeqRfth943bvEA")]
    [DisplayName("Abstain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Abstn")]
    #endif
    [IsoXmlTag("Abstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? Abstain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? Abstain { get; init; } 
    #else
    public QuantityOrCode1Choice_? Abstain { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    [IsoId("_8v8_q_NXEeqRfth943bvEA")]
    [DisplayName("Withhold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wthhld")]
    #endif
    [IsoXmlTag("Wthhld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? Withhold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? Withhold { get; init; } 
    #else
    public QuantityOrCode1Choice_? Withhold { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_8v8_rfNXEeqRfth943bvEA")]
    [DisplayName("With Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WthMgmt")]
    #endif
    [IsoXmlTag("WthMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? WithManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? WithManagement { get; init; } 
    #else
    public QuantityOrCode1Choice_? WithManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_8v8_r_NXEeqRfth943bvEA")]
    [DisplayName("Against Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgnstMgmt")]
    #endif
    [IsoXmlTag("AgnstMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? AgainstManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? AgainstManagement { get; init; } 
    #else
    public QuantityOrCode1Choice_? AgainstManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_8v8_sfNXEeqRfth943bvEA")]
    [DisplayName("Discretionary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dscrtnry")]
    #endif
    [IsoXmlTag("Dscrtnry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? Discretionary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? Discretionary { get; init; } 
    #else
    public QuantityOrCode1Choice_? Discretionary { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8v8_s_NXEeqRfth943bvEA")]
    [DisplayName("One Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneYr")]
    #endif
    [IsoXmlTag("OneYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? OneYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? OneYear { get; init; } 
    #else
    public QuantityOrCode1Choice_? OneYear { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8v8_tfNXEeqRfth943bvEA")]
    [DisplayName("Two Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoYrs")]
    #endif
    [IsoXmlTag("TwoYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? TwoYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? TwoYears { get; init; } 
    #else
    public QuantityOrCode1Choice_? TwoYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8v8_t_NXEeqRfth943bvEA")]
    [DisplayName("Three Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThreeYrs")]
    #endif
    [IsoXmlTag("ThreeYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? ThreeYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? ThreeYears { get; init; } 
    #else
    public QuantityOrCode1Choice_? ThreeYears { get; set; } 
    #endif
    
    /// <summary>
    /// Do not vote.
    /// </summary>
    [IsoId("_8v8_ufNXEeqRfth943bvEA")]
    [DisplayName("No Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoActn")]
    #endif
    [IsoXmlTag("NoActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? NoAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? NoAction { get; init; } 
    #else
    public QuantityOrCode1Choice_? NoAction { get; set; } 
    #endif
    
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_8v8_u_NXEeqRfth943bvEA")]
    [DisplayName("Blank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Blnk")]
    #endif
    [IsoXmlTag("Blnk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrCode1Choice_? Blank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrCode1Choice_? Blank { get; init; } 
    #else
    public QuantityOrCode1Choice_? Blank { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_8v8_vfNXEeqRfth943bvEA")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<ProprietaryVote1> Proprietary { get; init; } = new ValueList<ProprietaryVote1>(){};
    
    
    #nullable disable
    
}
