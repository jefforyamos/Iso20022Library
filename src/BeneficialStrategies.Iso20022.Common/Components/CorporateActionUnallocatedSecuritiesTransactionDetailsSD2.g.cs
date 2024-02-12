﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedSecuritiesTransactionDetailsSD2.  ISO2002 ID# _Z6ragWiLEeOdXoiw6mfXMw.
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
/// Breakdown of unallocated securities transactions.
/// </summary>
[IsoId("_Z6ragWiLEeOdXoiw6mfXMw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Unallocated Securities Transaction Details SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedSecuritiesTransactionDetailsSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionUnallocatedSecuritiesTransactionDetailsSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD2( CreditDebitCode reqCreditDebitIndicator )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_aUb-UWiLEeOdXoiw6mfXMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit Debit Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_aUb-eWiLEeOdXoiw6mfXMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    [IsoId("_aUb-WWiLEeOdXoiw6mfXMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_aUb-YWiLEeOdXoiw6mfXMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unallocated Reason Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCUnallocatedAdjustmentReason1Code? UnallocatedReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCUnallocatedAdjustmentReason1Code? UnallocatedReasonCode { get; init; } 
    #else
    public DTCUnallocatedAdjustmentReason1Code? UnallocatedReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_aUb-aWiLEeOdXoiw6mfXMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contra Participant Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContraParticipantNumber { get; init; } 
    #else
    public System.String? ContraParticipantNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_aUb-cWiLEeOdXoiw6mfXMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Earliest Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat28Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
