﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnilateralSplit1Choice.  ISO2002 ID# _QtogGdp-Ed-ak6NoX_4Aeg_510702003.
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
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(UnilateralSplit1Choice.Code))]
    [KnownType(typeof(UnilateralSplit1Choice.Proprietary))]
    [IsoId("_QtogGdp-Ed-ak6NoX_4Aeg_510702003")]
    [DisplayName("Unilateral Split 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnilateralSplit1Choice_
    #else
    public abstract partial class UnilateralSplit1Choice_
    #endif
    {
    }
}
