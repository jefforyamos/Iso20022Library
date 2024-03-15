﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ContractClosureReason1Choice.  ISO2002 ID# _X56BEArAEeWD-cmAqruRjw.
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
    /// Reason for the closure of the contract.
    /// </summary>
    [KnownType(typeof(ContractClosureReason1Choice.Code))]
    [KnownType(typeof(ContractClosureReason1Choice.Proprietary))]
    [IsoId("_X56BEArAEeWD-cmAqruRjw")]
    [DisplayName("Contract Closure Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractClosureReason1Choice_
    #else
    public abstract partial class ContractClosureReason1Choice_
    #endif
    {
    }
}
