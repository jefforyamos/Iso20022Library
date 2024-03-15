﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BorrowingReason1Choice.  ISO2002 ID# _AYq0IdokEeC60axPepSq7g_1157886245.
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
    /// Choice of format for the borrowing reason.
    /// </summary>
    [KnownType(typeof(BorrowingReason1Choice.Code))]
    [KnownType(typeof(BorrowingReason1Choice.Proprietary))]
    [IsoId("_AYq0IdokEeC60axPepSq7g_1157886245")]
    [DisplayName("Borrowing Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BorrowingReason1Choice_
    #else
    public abstract partial class BorrowingReason1Choice_
    #endif
    {
    }
}
