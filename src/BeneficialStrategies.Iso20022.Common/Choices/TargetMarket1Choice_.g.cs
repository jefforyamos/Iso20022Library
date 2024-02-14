﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TargetMarket1Choice.  ISO2002 ID# _QM-3EDcMEeiIxKQErQxblg.
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
    /// Choice of formats for the market for a type of investor expressed as a code.
    /// </summary>
    [KnownType(typeof(TargetMarket1Choice.Code))]
    [KnownType(typeof(TargetMarket1Choice.Proprietary))]
    [IsoId("_QM-3EDcMEeiIxKQErQxblg")]
    [DisplayName("Target Market 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TargetMarket1Choice_
    #else
    public abstract partial class TargetMarket1Choice_
    #endif
    {
    }
}
