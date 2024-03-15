﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferUnmatchedStatus3Choice.  ISO2002 ID# _duzpkSY4EeW_ZNn8gbfY7Q.
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
    /// Reason for the unmatched status.
    /// </summary>
    [KnownType(typeof(TransferUnmatchedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(TransferUnmatchedStatus3Choice.Reason))]
    [KnownType(typeof(TransferUnmatchedStatus3Choice.ExtendedReason))]
    [KnownType(typeof(TransferUnmatchedStatus3Choice.DataSourceScheme))]
    [IsoId("_duzpkSY4EeW_ZNn8gbfY7Q")]
    [DisplayName("Transfer Unmatched Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferUnmatchedStatus3Choice_
    #else
    public abstract partial class TransferUnmatchedStatus3Choice_
    #endif
    {
    }
}
