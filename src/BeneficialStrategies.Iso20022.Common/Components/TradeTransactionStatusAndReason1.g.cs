﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionStatusAndReason1.  ISO2002 ID# _RXNBgNp-Ed-ak6NoX_4Aeg_1004804431.
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
/// Identifies the transaction with a trade reference and provides its status. If the status is rejected, a reason for this status must be given.
/// </summary>
[IsoId("_RXNBgNp-Ed-ak6NoX_4Aeg_1004804431")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Trade Transaction Status And Reason")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransactionStatusAndReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransactionStatusAndReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransactionStatusAndReason1( System.String reqRelatedReference,System.String reqTradeReference,Status2Code reqStatus )
    {
        RelatedReference = reqRelatedReference;
        TradeReference = reqTradeReference;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReport document that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_RXNBgdp-Ed-ak6NoX_4Aeg_494321735")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RelatedReference { get; init; } 
    #else
    public System.String RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_RXNBgtp-Ed-ak6NoX_4Aeg_-1568988274")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text TradeReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeReference { get; init; } 
    #else
    public System.String TradeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the status of a trade transaction.
    /// </summary>
    [IsoId("_RXNBg9p-Ed-ak6NoX_4Aeg_461506778")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Status2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status2Code Status { get; init; } 
    #else
    public Status2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the report is rejected and provides a reason why.
    /// </summary>
    [IsoId("_RXNBhNp-Ed-ak6NoX_4Aeg_1291723379")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejected")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(1)]
    [MaxLength(100)]
    #endif
    public ValueList<RejectedStatusReason9Choice_> Rejected { get; init; } = new ValueList<RejectedStatusReason9Choice_>(){};
    
    
    #nullable disable
    
}
