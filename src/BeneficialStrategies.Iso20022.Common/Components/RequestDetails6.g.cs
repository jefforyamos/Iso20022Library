﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails6.  ISO2002 ID# _5VWQEeDVEd-udr336SN7mQ.
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
/// Details of the settlement condition modification request.
/// </summary>
[IsoId("_5VWQEeDVEd-udr336SN7mQ")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails6( References7 reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_5VWQE-DVEd-udr336SN7mQ")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References7 Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References7 Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References7 Reference { get; init; } 
    #else
    public References7 Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_5VWQFeDVEd-udr336SN7mQ")]
    [DisplayName("Automatic Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcBrrwg")]
    #endif
    [IsoXmlTag("AutomtcBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; init; } 
    #else
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_5VWQF-DVEd-udr336SN7mQ")]
    [DisplayName("Retain Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtnInd")]
    #endif
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RetainIndicator { get; init; } 
    #else
    public System.String? RetainIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_5VWQGeDVEd-udr336SN7mQ")]
    [DisplayName("Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lkg")]
    #endif
    [IsoXmlTag("Lkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LinkageType1Choice_? Linkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LinkageType1Choice_? Linkage { get; init; } 
    #else
    public LinkageType1Choice_? Linkage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_5VWQG-DVEd-udr336SN7mQ")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityNumeric1Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityNumeric1Choice_? Priority { get; init; } 
    #else
    public PriorityNumeric1Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_5VWQHeDVEd-udr336SN7mQ")]
    [DisplayName("Other Processing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrcg")]
    #endif
    [IsoXmlTag("OthrPrcg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification20? OtherProcessing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification20? OtherProcessing { get; init; } 
    #else
    public GenericIdentification20? OtherProcessing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_5VWQH-DVEd-udr336SN7mQ")]
    [DisplayName("Partial Settlement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlSttlmInd")]
    #endif
    [IsoXmlTag("PrtlSttlmInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    #else
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_5VWQIeDVEd-udr336SN7mQ")]
    [DisplayName("Securities RTGS")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesRTGS")]
    #endif
    [IsoXmlTag("SctiesRTGS")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; } 
    #else
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_5VWQI-DVEd-udr336SN7mQ")]
    [DisplayName("Hold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldInd")]
    #endif
    [IsoXmlTag("HldInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HoldIndicator2? HoldIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HoldIndicator2? HoldIndicator { get; init; } 
    #else
    public HoldIndicator2? HoldIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_5VWQJeDVEd-udr336SN7mQ")]
    [DisplayName("Matching Denial")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgDnl")]
    #endif
    [IsoXmlTag("MtchgDnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingDenied1Choice_? MatchingDenial { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingDenied1Choice_? MatchingDenial { get; init; } 
    #else
    public MatchingDenied1Choice_? MatchingDenial { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_5VWQJ-DVEd-udr336SN7mQ")]
    [DisplayName("Unilateral Split")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnltrlSplt")]
    #endif
    [IsoXmlTag("UnltrlSplt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnilateralSplit1Choice_? UnilateralSplit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnilateralSplit1Choice_? UnilateralSplit { get; init; } 
    #else
    public UnilateralSplit1Choice_? UnilateralSplit { get; set; } 
    #endif
    
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_5VWQKeDVEd-udr336SN7mQ")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages10? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages10? Linkages { get; init; } 
    #else
    public Linkages10? Linkages { get; set; } 
    #endif
    
    
    #nullable disable
    
}
