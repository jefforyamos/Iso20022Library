﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeType5Choice.  ISO2002 ID# _KJb5gDh5EeaH-93K5JKmzw.
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
    /// Choice of formats for the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType5Choice.Code))]
    [KnownType(typeof(ChargeType5Choice.Proprietary))]
    [IsoId("_KJb5gDh5EeaH-93K5JKmzw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charge Type 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType5Choice_
    #else
    public abstract partial class ChargeType5Choice_
    #endif
    {
    }
}
