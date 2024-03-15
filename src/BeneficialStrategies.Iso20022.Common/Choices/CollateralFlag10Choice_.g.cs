﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralFlag10Choice.  ISO2002 ID# _gDYXUQAAEeqefbt-QjTNnA.
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
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [KnownType(typeof(CollateralFlag10Choice.Collateralised))]
    [KnownType(typeof(CollateralFlag10Choice.Uncollateralised))]
    [IsoId("_gDYXUQAAEeqefbt-QjTNnA")]
    [DisplayName("Collateral Flag 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralFlag10Choice_
    #else
    public abstract partial class CollateralFlag10Choice_
    #endif
    {
    }
}
