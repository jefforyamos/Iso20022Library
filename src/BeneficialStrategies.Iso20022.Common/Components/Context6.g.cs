﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Context6.  ISO2002 ID# _O6b2QeE6EeeV6-yubHrZaQ.
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
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_O6b2QeE6EeeV6-yubHrZaQ")]
[DisplayName("Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Context6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_PGLzQeE6EeeV6-yubHrZaQ")]
    [DisplayName("Transaction Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCntxt")]
    #endif
    [IsoXmlTag("TxCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionContext6? TransactionContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionContext6? TransactionContext { get; init; } 
    #else
    public TransactionContext6? TransactionContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
