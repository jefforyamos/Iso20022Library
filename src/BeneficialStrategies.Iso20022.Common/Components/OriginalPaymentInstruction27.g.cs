﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction27.  ISO2002 ID# _jV5c4bPfEeeppqgHuc69jg.
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
/// Provides details information on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_jV5c4bPfEeeppqgHuc69jg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Original Payment Instruction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalPaymentInstruction27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalPaymentInstruction27 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalPaymentInstruction27( System.String reqOriginalPaymentInformationIdentification )
    {
        OriginalPaymentInformationIdentification = reqOriginalPaymentInformationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_je-ga7PfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Payment Information Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String OriginalPaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalPaymentInformationIdentification { get; init; } 
    #else
    public System.String OriginalPaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_je-gbbPfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Number Of Transactions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalNumberOfTransactions { get; init; } 
    #else
    public System.String? OriginalNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_je-gb7PfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Control Sum")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OriginalControlSum { get; init; } 
    #else
    public System.UInt64? OriginalControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_je-gcbPfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Information Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; } 
    #else
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_je-gc7PfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status Reason Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation11? StatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation11? StatusReasonInformation { get; init; } 
    #else
    public StatusReasonInformation11? StatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_je-gdbPfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Transactions Per Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; init; } 
    #else
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_je-gd7PfEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction92? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction92? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransaction92? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
