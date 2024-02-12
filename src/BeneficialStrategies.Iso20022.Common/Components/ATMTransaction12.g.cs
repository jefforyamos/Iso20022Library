﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction12.  ISO2002 ID# _NBXnUYt2EeSLQutgI1Ulfw.
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
/// Information about the reconciliation response.
/// </summary>
[IsoId("_NBXnUYt2EeSLQutgI1Ulfw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("ATM Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction12( TransactionIdentifier1 reqTransactionIdentification,System.String reqReconciliationIdentification,ResponseType3 reqTransactionResponse )
    {
        TransactionIdentification = reqTransactionIdentification;
        ReconciliationIdentification = reqReconciliationIdentification;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_M_NnwCrCEeWRf8RNsvC5fQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type Of Operation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMOperation1Code? TypeOfOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMOperation1Code? TypeOfOperation { get; init; } 
    #else
    public ATMOperation1Code? TypeOfOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation transaction.
    /// </summary>
    [IsoId("_h0fNgCrCEeWRf8RNsvC5fQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_NNcUc4t2EeSLQutgI1Ulfw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reconciliation Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReconciliationIdentification { get; init; } 
    #else
    public System.String ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the reconciliation.
    /// </summary>
    [IsoId("_NNcUd4t2EeSLQutgI1Ulfw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType3 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ResponseType3 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType3 TransactionResponse { get; init; } 
    #else
    public ResponseType3 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_NNcUfYt2EeSLQutgI1Ulfw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Command")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand1? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand1? Command { get; init; } 
    #else
    public ATMCommand1? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
