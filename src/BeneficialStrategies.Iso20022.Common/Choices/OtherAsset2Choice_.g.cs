﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OtherAsset2Choice.  ISO2002 ID# _-9ZlgZNBEemQB_8XA98K0Q.
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
    /// Choice of formats for a type of other asset.
    /// </summary>
    [KnownType(typeof(OtherAsset2Choice.Code))]
    [KnownType(typeof(OtherAsset2Choice.Proprietary))]
    [IsoId("_-9ZlgZNBEemQB_8XA98K0Q")]
    [DisplayName("Other Asset 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OtherAsset2Choice_
    #else
    public abstract partial class OtherAsset2Choice_
    #endif
    {
    }
}
