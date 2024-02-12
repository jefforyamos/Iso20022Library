﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UniqueTransactionIdentifier2.  ISO2002 ID# _sIgRQVNgEeOEi5J12GuNGQ.
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
/// Specifies the unique transaction identifier (UTI) that was created at the time a transaction was first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime and optionally, the prior unique transaction identifier (PUTI). These identifiers can also be known as the Unique Swap Identifier (USI) or the Prior Unique Swap Identifier (PUSI).
/// </summary>
[IsoId("_sIgRQVNgEeOEi5J12GuNGQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Unique Transaction Identifier")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UniqueTransactionIdentifier2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UniqueTransactionIdentifier2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UniqueTransactionIdentifier2( System.String reqUniqueTransactionIdentifier )
    {
        UniqueTransactionIdentifier = reqUniqueTransactionIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime. This identifier can also be known as the Unique Swap Identifier (USI).
    /// </summary>
    [IsoId("_sbuvQVNgEeOEi5J12GuNGQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unique Transaction Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text UniqueTransactionIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String UniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UniqueTransactionIdentifier { get; init; } 
    #else
    public System.String UniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Prior unique transaction identifier specifies the previous unique transaction identifier (UTI) that was created at the time the transaction was executed. This identifier can also be known as the Prior Unique Swap Identifier (PUSI).
    /// </summary>
    [IsoId("_sbuvQ1NgEeOEi5J12GuNGQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Prior Unique Transaction Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? PriorUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PriorUniqueTransactionIdentifier { get; init; } 
    #else
    public System.String? PriorUniqueTransactionIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
