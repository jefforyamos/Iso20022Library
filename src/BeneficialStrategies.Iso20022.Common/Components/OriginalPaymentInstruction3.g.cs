﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction3.  ISO2002 ID# _sffO8lkyEeGeoaLUQk__nA_671180780.
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
/// Provides the details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_sffO8lkyEeGeoaLUQk__nA_671180780")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Original Payment Instruction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalPaymentInstruction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalPaymentInstruction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalPaymentInstruction3( System.String reqOriginalPaymentInformationIdentification )
    {
        OriginalPaymentInformationIdentification = reqOriginalPaymentInformationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    [IsoId("_sfo_8FkyEeGeoaLUQk__nA_-439730639")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Payment Information Cancellation Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalPaymentInformationCancellationIdentification { get; init; } 
    #else
    public System.String? OriginalPaymentInformationCancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_sfo_8VkyEeGeoaLUQk__nA_-1852187635")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Resolved Case")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case3? ResolvedCase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case3? ResolvedCase { get; init; } 
    #else
    public Case3? ResolvedCase { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_sfo_8lkyEeGeoaLUQk__nA_136833146")]
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
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_sfyJ4FkyEeGeoaLUQk__nA_1392972156")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation3? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_sfyJ4VkyEeGeoaLUQk__nA_1847059425")]
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
    [IsoId("_sfyJ4lkyEeGeoaLUQk__nA_-33246215")]
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
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    [IsoId("_sf764FkyEeGeoaLUQk__nA_-1861960845")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Information Cancellation Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    #else
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_sf764VkyEeGeoaLUQk__nA_260743073")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation Status Reason Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; } 
    #else
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_sf764lkyEeGeoaLUQk__nA_185810367")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    #else
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_sgFr4FkyEeGeoaLUQk__nA_-370926601")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction39? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction39? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransaction39? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
