﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferStatusType1Choice.  ISO2002 ID# _BjiYwFNYEeijdq8ilaxyOA.
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
    /// Choice of formats for a type of status or event.
    /// </summary>
    [KnownType(typeof(TransferStatusType1Choice.Code))]
    [KnownType(typeof(TransferStatusType1Choice.Proprietary))]
    [IsoId("_BjiYwFNYEeijdq8ilaxyOA")]
    [DisplayName("Transfer Status Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferStatusType1Choice_
    #else
    public abstract partial class TransferStatusType1Choice_
    #endif
    {
    }
}
