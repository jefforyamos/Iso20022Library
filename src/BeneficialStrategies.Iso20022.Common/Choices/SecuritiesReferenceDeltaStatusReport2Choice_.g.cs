﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesReferenceDeltaStatusReport2Choice.  ISO2002 ID# _2XCW1Hv0EeanCNPcMT7sSg.
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
    /// Choice defining financial instruments that are either new or have been modified.
    /// </summary>
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord))]
    [IsoId("_2XCW1Hv0EeanCNPcMT7sSg")]
    [DisplayName("Securities Reference Delta Status Report 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesReferenceDeltaStatusReport2Choice_
    #else
    public abstract partial class SecuritiesReferenceDeltaStatusReport2Choice_
    #endif
    {
    }
}
