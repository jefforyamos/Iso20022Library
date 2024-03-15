﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote18.  ISO2002 ID# _y9dHgTUHEe2tRf29bleifQ.
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
/// Vote results for one resolution.
/// </summary>
[IsoId("_y9dHgTUHEe2tRf29bleifQ")]
[DisplayName("Vote")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vote18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vote18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vote18( System.String reqIssuerLabel,ResolutionStatus2Code reqResolutionStatus )
    {
        IssuerLabel = reqIssuerLabel;
        ResolutionStatus = reqResolutionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_zV41ozUHEe2tRf29bleifQ")]
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
    /// Language, title and textual description of an agenda resolution. 
    /// </summary>
    [IsoId("_27EMkjUHEe2tRf29bleifQ")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ItemDescription1? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ItemDescription1? Description { get; init; } 
    #else
    public ItemDescription1? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptance status of the resolution.
    /// </summary>
    [IsoId("_zV41pTUHEe2tRf29bleifQ")]
    [DisplayName("Resolution Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnSts")]
    #endif
    [IsoXmlTag("RsltnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResolutionStatus2Code ResolutionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResolutionStatus2Code ResolutionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionStatus2Code ResolutionStatus { get; init; } 
    #else
    public ResolutionStatus2Code ResolutionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the resolution is a new or an amended resolution.
    /// </summary>
    [IsoId("_27EMkzUHEe2tRf29bleifQ")]
    [DisplayName("Sub Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubSts")]
    #endif
    [IsoXmlTag("SubSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResolutionSubStatus1Code? SubStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionSubStatus1Code? SubStatus { get; init; } 
    #else
    public ResolutionSubStatus1Code? SubStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_zV41pzUHEe2tRf29bleifQ")]
    [DisplayName("For")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="For")]
    #endif
    [IsoXmlTag("For")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? For { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_zV41qTUHEe2tRf29bleifQ")]
    [DisplayName("Against")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agnst")]
    #endif
    [IsoXmlTag("Agnst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Against { get; set; } 
    #endif
    
    /// <summary>
    /// Number of abstention votes.
    /// </summary>
    [IsoId("_zV41qzUHEe2tRf29bleifQ")]
    [DisplayName("Abstain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Abstn")]
    #endif
    [IsoXmlTag("Abstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Abstain { get; set; } 
    #endif
    
    /// <summary>
    /// Total votes withheld, for example, in the case where a shareholder wishes not to endorse the election of a board member.
    /// </summary>
    [IsoId("_zV41rTUHEe2tRf29bleifQ")]
    [DisplayName("Withhold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wthhld")]
    #endif
    [IsoXmlTag("Wthhld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Withhold { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_zV41rzUHEe2tRf29bleifQ")]
    [DisplayName("With Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WthMgmt")]
    #endif
    [IsoXmlTag("WthMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_zV41sTUHEe2tRf29bleifQ")]
    [DisplayName("Against Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgnstMgmt")]
    #endif
    [IsoXmlTag("AgnstMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which the decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_zV41szUHEe2tRf29bleifQ")]
    [DisplayName("Discretionary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dscrtnry")]
    #endif
    [IsoXmlTag("Dscrtnry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_zV41tTUHEe2tRf29bleifQ")]
    [DisplayName("One Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneYr")]
    #endif
    [IsoXmlTag("OneYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? OneYear { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_zV41tzUHEe2tRf29bleifQ")]
    [DisplayName("Two Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoYrs")]
    #endif
    [IsoXmlTag("TwoYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_zV41uTUHEe2tRf29bleifQ")]
    [DisplayName("Three Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThreeYrs")]
    #endif
    [IsoXmlTag("ThreeYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_zV41uzUHEe2tRf29bleifQ")]
    [DisplayName("No Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoActn")]
    #endif
    [IsoXmlTag("NoActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? NoAction { get; set; } 
    #endif
    
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_zV41vTUHEe2tRf29bleifQ")]
    [DisplayName("Blank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Blnk")]
    #endif
    [IsoXmlTag("Blnk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Blank { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_zV41vzUHEe2tRf29bleifQ")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<ProprietaryVote2> Proprietary { get; init; } = new ValueList<ProprietaryVote2>(){};
    
    
    #nullable disable
    
}
