﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for QuorumQuantity1Choice.  ISO2002 ID# _RDiepdp-Ed-ak6NoX_4Aeg_1841562834.
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
    /// Choice of quorum quantity.
    /// </summary>
    [KnownType(typeof(QuorumQuantity1Choice.QuorumQuantity))]
    [KnownType(typeof(QuorumQuantity1Choice.QuorumQuantityPercentage))]
    [IsoId("_RDiepdp-Ed-ak6NoX_4Aeg_1841562834")]
    [DisplayName("Quorum Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuorumQuantity1Choice_
    #else
    public abstract partial class QuorumQuantity1Choice_
    #endif
    {
    }
}
