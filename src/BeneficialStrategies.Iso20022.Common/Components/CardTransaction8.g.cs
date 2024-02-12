﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransaction8.  ISO2002 ID# _02pT8Xu3EeS2Z_kGi7H1VQ.
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
/// Card transaction for which the authorisation has been requested.
/// </summary>
[IsoId("_02pT8Xu3EeS2Z_kGi7H1VQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransaction8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransaction8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransaction8( CardPaymentServiceType7Code reqTransactionType,System.DateTime reqAcceptorTransactionDateTime,System.String reqInitiatorTransactionIdentification,CardTransactionDetail6 reqTransactionDetails,ResponseType2 reqTransactionResponse )
    {
        TransactionType = reqTransactionType;
        AcceptorTransactionDateTime = reqAcceptorTransactionDateTime;
        InitiatorTransactionIdentification = reqInitiatorTransactionIdentification;
        TransactionDetails = reqTransactionDetails;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction being undertaken for the main service. 
    /// It correspond partially to the ISO 8583, field number 3.
    /// </summary>
    [IsoId("_1Ddn8Xu3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentServiceType7Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentServiceType7Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType7Code TransactionType { get; init; } 
    #else
    public CardPaymentServiceType7Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_1Ddn83u3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reconciliation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier2? Reconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier2? Reconciliation { get; init; } 
    #else
    public TransactionIdentifier2? Reconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the transaction transported unchanged by the acquirer from the card acceptor to the issuer. Corresponds to the CAPE data element TransactionIdentification/ TransactionDateTime.
    /// It correspond to the ISO 8583, field number 12.
    /// </summary>
    [IsoId("_1Ddn9Xu3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acceptor Transaction Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime AcceptorTransactionDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime AcceptorTransactionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime AcceptorTransactionDateTime { get; init; } 
    #else
    public System.DateTime AcceptorTransactionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Number generated by the transaction Initiator to assist in identifying a transaction uniquely. This value remains unchanged for all messages within a message pair exchange, for instance an initiation/response. It corresponds to the ISO 8583 field number 11.
    /// </summary>
    [IsoId("_1Ddn93u3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Initiator Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InitiatorTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String InitiatorTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InitiatorTransactionIdentification { get; init; } 
    #else
    public System.String InitiatorTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to match transactions throughout their life cycle (for example, authorisation to financial presentment, financial presentment to chargeback). It shall contain the same value in all messages throughout a transaction’s life cycle. It corresponds partially to ISO 8583: 2003 field number 21.
    /// </summary>
    [IsoId("_1Ddn-Xu3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Life Cycle Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionLifeCycleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionLifeCycleIdentification { get; init; } 
    #else
    public System.String? TransactionLifeCycleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Life cycle transaction sequence number when multiple authorisations are performed for the same presentment.
    /// It corresponds partially to ISO 8583: 2003, field number 21.
    /// </summary>
    [IsoId("_1Ddn-3u3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Life Cycle Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TransactionLifeCycleSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TransactionLifeCycleSequenceNumber { get; init; } 
    #else
    public System.UInt64? TransactionLifeCycleSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions under the same life cycle transaction sequence number.
    /// </summary>
    [IsoId("_FOLEQIIUEeSvPp7yXrNQIw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Life Cycle Sequence Counter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TransactionLifeCycleSequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TransactionLifeCycleSequenceCounter { get; init; } 
    #else
    public System.UInt64? TransactionLifeCycleSequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the card transaction.
    /// </summary>
    [IsoId("_1Ddn_Xu3EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardTransactionDetail6 TransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardTransactionDetail6 TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionDetail6 TransactionDetails { get; init; } 
    #else
    public CardTransactionDetail6 TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Response to the reversal.
    /// </summary>
    [IsoId("_H8X1IIOvEeSEK-wW9DMTWw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType2 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ResponseType2 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType2 TransactionResponse { get; init; } 
    #else
    public ResponseType2 TransactionResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
