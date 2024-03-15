﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeType3Choice.  ISO2002 ID# _tjJEUVkyEeGeoaLUQk__nA_-594962709.
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
    /// Specifies the charge type.
    /// </summary>
    [KnownType(typeof(ChargeType3Choice.Code))]
    [KnownType(typeof(ChargeType3Choice.Proprietary))]
    [IsoId("_tjJEUVkyEeGeoaLUQk__nA_-594962709")]
    [DisplayName("Charge Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType3Choice_
    #else
    public abstract partial class ChargeType3Choice_
    #endif
    {
    }
}
