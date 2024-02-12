﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActivityReportItems2.  ISO2002 ID# _RZ5JL9p-Ed-ak6NoX_4Aeg_-990880323.
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
/// Describes the events that occurred for one transaction.
/// </summary>
[IsoId("_RZ5JL9p-Ed-ak6NoX_4Aeg_-990880323")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Activity Report Items")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActivityReportItems2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActivityReportItems2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActivityReportItems2( System.String reqTransactionIdentification,BICIdentification1 reqReportedEntity )
    {
        TransactionIdentification = reqTransactionIdentification;
        ReportedEntity = reqReportedEntity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_RZ5JMNp-Ed-ak6NoX_4Aeg_-990880292")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_RZ5JMdp-Ed-ak6NoX_4Aeg_-990880200")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("User Transaction Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(2)]
    #endif
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Entity for which the activity is reported.
    /// </summary>
    [IsoId("_RaCTENp-Ed-ak6NoX_4Aeg_-990880230")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reported Entity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 ReportedEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BICIdentification1 ReportedEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 ReportedEntity { get; init; } 
    #else
    public BICIdentification1 ReportedEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Describes an activity that took place during a period.
    /// </summary>
    [IsoId("_RaCTEdp-Ed-ak6NoX_4Aeg_-990880169")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reported Item")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public ActivityDetails1? ReportedItem { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _RaCTEdp-Ed-ak6NoX_4Aeg_-990880169
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_RaCTEtp-Ed-ak6NoX_4Aeg_-990880261")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pending Request For Action")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? PendingRequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? PendingRequestForAction { get; init; } 
    #else
    public PendingActivity2? PendingRequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
