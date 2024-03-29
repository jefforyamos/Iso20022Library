﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for VoteInstructionType2Choice.  ISO2002 ID# _XuyKVfNoEeqRfth943bvEA.
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
    /// Choice between a predefined code value or a proprietary code value for a vote instruction type. 
    /// </summary>
    [KnownType(typeof(VoteInstructionType2Choice.Type))]
    [KnownType(typeof(VoteInstructionType2Choice.Proprietary))]
    [IsoId("_XuyKVfNoEeqRfth943bvEA")]
    [DisplayName("Vote Instruction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VoteInstructionType2Choice_
    #else
    public abstract partial class VoteInstructionType2Choice_
    #endif
    {
    }
}
