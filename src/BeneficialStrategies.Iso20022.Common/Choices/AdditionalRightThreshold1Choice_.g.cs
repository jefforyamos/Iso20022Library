﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdditionalRightThreshold1Choice.  ISO2002 ID# _RDrok9p-Ed-ak6NoX_4Aeg_1316358552.
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
    /// Choice of additional right threshold.
    /// </summary>
    [KnownType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThreshold))]
    [KnownType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage))]
    [IsoId("_RDrok9p-Ed-ak6NoX_4Aeg_1316358552")]
    [DisplayName("Additional Right Threshold 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalRightThreshold1Choice_
    #else
    public abstract partial class AdditionalRightThreshold1Choice_
    #endif
    {
    }
}
