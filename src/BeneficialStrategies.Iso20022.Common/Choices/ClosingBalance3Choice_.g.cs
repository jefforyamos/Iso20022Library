﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClosingBalance3Choice.  ISO2002 ID# _t8VGsAgHEeSxsfb1OEDVsw.
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
    /// Choice of final and intermediary balances.
    /// </summary>
    [KnownType(typeof(ClosingBalance3Choice.FinalClosingBalance))]
    [KnownType(typeof(ClosingBalance3Choice.IntermediaryClosingBalance))]
    [IsoId("_t8VGsAgHEeSxsfb1OEDVsw")]
    [DisplayName("Closing Balance 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance3Choice_
    #else
    public abstract partial class ClosingBalance3Choice_
    #endif
    {
    }
}
