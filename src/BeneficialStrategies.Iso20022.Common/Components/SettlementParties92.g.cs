﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties92.  ISO2002 ID# _fpZHfffYEeiNZp_PtLohLw.
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
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_fpZHfffYEeiNZp_PtLohLw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Settlement Parties")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementParties92
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    [IsoId("_fpZHh_fYEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount176? Party2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount176? Party2 { get; init; } 
    #else
    public PartyIdentificationAndAccount176? Party2 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    [IsoId("_fpZHiffYEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount176? Party3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount176? Party3 { get; init; } 
    #else
    public PartyIdentificationAndAccount176? Party3 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    [IsoId("_fpZHi_fYEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount176? Party4 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount176? Party4 { get; init; } 
    #else
    public PartyIdentificationAndAccount176? Party4 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    [IsoId("_fpZHjffYEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount176? Party5 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount176? Party5 { get; init; } 
    #else
    public PartyIdentificationAndAccount176? Party5 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
