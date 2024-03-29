﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BlockTrade1Choice.  ISO2002 ID# _QvuKwtp-Ed-ak6NoX_4Aeg_333347197.
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
    /// Choice of format for the block trade information.
    /// </summary>
    [KnownType(typeof(BlockTrade1Choice.Code))]
    [KnownType(typeof(BlockTrade1Choice.Proprietary))]
    [IsoId("_QvuKwtp-Ed-ak6NoX_4Aeg_333347197")]
    [DisplayName("Block Trade 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BlockTrade1Choice_
    #else
    public abstract partial class BlockTrade1Choice_
    #endif
    {
    }
}
