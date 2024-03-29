﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairStatus14Choice.  ISO2002 ID# _iYMV4Tw5EeW3QqUkIQtIUA.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus14Choice.Reason))]
    [IsoId("_iYMV4Tw5EeW3QqUkIQtIUA")]
    [DisplayName("Repair Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairStatus14Choice_
    #else
    public abstract partial class RepairStatus14Choice_
    #endif
    {
    }
}
