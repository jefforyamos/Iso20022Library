﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionType1CodeChoice.  ISO2002 ID# _U0V2wdp-Ed-ak6NoX_4Aeg_1816953757.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the transaction type.
    /// </summary>
    [KnownType(typeof(TransactionType1CodeChoice.Structured))]
    [KnownType(typeof(TransactionType1CodeChoice.Unstructured))]
    [IsoId("_U0V2wdp-Ed-ak6NoX_4Aeg_1816953757")]
    [DisplayName("Transaction Type 1 Code Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionType1CodeChoice_
    #else
    public abstract partial class TransactionType1CodeChoice_
    #endif
    {
    }
}
