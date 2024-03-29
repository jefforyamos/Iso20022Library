﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UniqueTransactionIdentifier2Choice.  ISO2002 ID# _ctnq8SyFEe2xAdY9t5fB3g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueTransactionIdentifier2Choice.UniqueTransactionIdentifier))]
    [KnownType(typeof(UniqueTransactionIdentifier2Choice.Proprietary))]
    [IsoId("_ctnq8SyFEe2xAdY9t5fB3g")]
    [DisplayName("Unique Transaction Identifier 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UniqueTransactionIdentifier2Choice_
    #else
    public abstract partial class UniqueTransactionIdentifier2Choice_
    #endif
    {
    }
}
