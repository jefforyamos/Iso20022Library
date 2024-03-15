﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References60Choice.  ISO2002 ID# _8T7An5NLEeWGlc8L7oPDIg.
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
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References60Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References60Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References60Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References60Choice.OtherTransactionIdentification))]
    [IsoId("_8T7An5NLEeWGlc8L7oPDIg")]
    [DisplayName("References 60 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References60Choice_
    #else
    public abstract partial class References60Choice_
    #endif
    {
    }
}
