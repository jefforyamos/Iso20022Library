﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReasonInformation8.  ISO2002 ID# _TRPsUNp-Ed-ak6NoX_4Aeg_1156620566.
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
/// Set of elements used to provide information on the status reason of the transaction.
/// </summary>
[IsoId("_TRPsUNp-Ed-ak6NoX_4Aeg_1156620566")]
[DisplayName("Status Reason Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReasonInformation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_TRPsUdp-Ed-ak6NoX_4Aeg_1156620782")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? Originator { get; init; } 
    #else
    public PartyIdentification32? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_TRPsUtp-Ed-ak6NoX_4Aeg_1156620691")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReason6Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReason6Choice_? Reason { get; init; } 
    #else
    public StatusReason6Choice_? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_TRPsU9p-Ed-ak6NoX_4Aeg_1156620597")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
