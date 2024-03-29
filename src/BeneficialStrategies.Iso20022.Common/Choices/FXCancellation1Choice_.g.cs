﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FXCancellation1Choice.  ISO2002 ID# _QtVlIdp-Ed-ak6NoX_4Aeg_615585032.
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
    /// Choice of format for the FX cancellation information.
    /// </summary>
    [KnownType(typeof(FXCancellation1Choice.Indicator))]
    [KnownType(typeof(FXCancellation1Choice.Proprietary))]
    [IsoId("_QtVlIdp-Ed-ak6NoX_4Aeg_615585032")]
    [DisplayName("FX Cancellation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FXCancellation1Choice_
    #else
    public abstract partial class FXCancellation1Choice_
    #endif
    {
    }
}
