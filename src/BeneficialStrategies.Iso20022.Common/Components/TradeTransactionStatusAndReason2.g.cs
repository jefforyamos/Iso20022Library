﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionStatusAndReason2.  ISO2002 ID# _RXgjh9p-Ed-ak6NoX_4Aeg_587723747.
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
/// Identifies the transaction with a trade reference and provides its status. If the status is rejected, a reason for this status must be given.
/// </summary>
[IsoId("_RXgjh9p-Ed-ak6NoX_4Aeg_587723747")]
[DisplayName("Trade Transaction Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransactionStatusAndReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransactionStatusAndReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransactionStatusAndReason2( System.String reqRelatedReference,System.String reqTradeReference,Status2Code reqStatus )
    {
        RelatedReference = reqRelatedReference;
        TradeReference = reqTradeReference;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReportCancellationRequest document that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_RXgjiNp-Ed-ak6NoX_4Aeg_851724068")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RelatedReference { get; init; } 
    #else
    public System.String RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_RXgjidp-Ed-ak6NoX_4Aeg_987608632")]
    [DisplayName("Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRef")]
    #endif
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text TradeReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeReference { get; init; } 
    #else
    public System.String TradeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the status of an instruction, request or report message.
    /// </summary>
    [IsoId("_RXgjitp-Ed-ak6NoX_4Aeg_587724041")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status2Code Status { get; init; } 
    #else
    public Status2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the cancellation is rejected and provides a reason why.
    /// </summary>
    [IsoId("_RXptcNp-Ed-ak6NoX_4Aeg_587724102")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<RejectedCancellationStatusReason1Choice_> Rejected { get; init; } = new ValueList<RejectedCancellationStatusReason1Choice_>(){};
    
    
    #nullable disable
    
}
