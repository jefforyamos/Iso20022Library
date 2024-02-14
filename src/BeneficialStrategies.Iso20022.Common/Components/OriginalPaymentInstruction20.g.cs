﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction20.  ISO2002 ID# _w_UlZUgtEeaGKYpLDboHPQ.
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
/// Provides details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_w_UlZUgtEeaGKYpLDboHPQ")]
[DisplayName("Original Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalPaymentInstruction20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalPaymentInstruction20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalPaymentInstruction20( System.String reqOriginalPaymentInformationIdentification )
    {
        OriginalPaymentInformationIdentification = reqOriginalPaymentInformationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_xI9CeUgtEeaGKYpLDboHPQ")]
    [DisplayName("Payment Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCxlId")]
    #endif
    [IsoXmlTag("PmtCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentCancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentCancellationIdentification { get; init; } 
    #else
    public System.String? PaymentCancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_xI9Ce0gtEeaGKYpLDboHPQ")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case3? Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case3? Case { get; init; } 
    #else
    public Case3? Case { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    [IsoId("_xI9CfUgtEeaGKYpLDboHPQ")]
    [DisplayName("Original Payment Information Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfId")]
    #endif
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalPaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalPaymentInformationIdentification { get; init; } 
    #else
    public System.String OriginalPaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_xI9Cf0gtEeaGKYpLDboHPQ")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation3? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    [IsoId("_xI9CgUgtEeaGKYpLDboHPQ")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfTransactions { get; init; } 
    #else
    public System.String? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_xI9Cg0gtEeaGKYpLDboHPQ")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_xI9ChUgtEeaGKYpLDboHPQ")]
    [DisplayName("Payment Information Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInfCxl")]
    #endif
    [IsoXmlTag("PmtInfCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentInformationCancellation { get; init; } 
    #else
    public System.String? PaymentInformationCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_xI9Ch0gtEeaGKYpLDboHPQ")]
    [DisplayName("Cancellation Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsnInf")]
    #endif
    [IsoXmlTag("CxlRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCancellationReason3? CancellationReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationReason3? CancellationReasonInformation { get; init; } 
    #else
    public PaymentCancellationReason3? CancellationReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_xI9CiUgtEeaGKYpLDboHPQ")]
    [DisplayName("Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInf")]
    #endif
    [IsoXmlTag("TxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction74? TransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction74? TransactionInformation { get; init; } 
    #else
    public PaymentTransaction74? TransactionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
