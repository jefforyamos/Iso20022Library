﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnderlyingIdentification2Choice.  ISO2002 ID# _Ko9qBYG-EeaalK9UbuVGFw.
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
    /// Details of the underlying of a security transaction.
    /// </summary>
    [KnownType(typeof(UnderlyingIdentification2Choice.Swap))]
    [KnownType(typeof(UnderlyingIdentification2Choice.Other))]
    [IsoId("_Ko9qBYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Identification 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingIdentification2Choice_
    #else
    public abstract partial class UnderlyingIdentification2Choice_
    #endif
    {
    }
}
