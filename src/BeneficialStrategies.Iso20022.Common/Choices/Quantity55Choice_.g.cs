﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Quantity55Choice.  ISO2002 ID# _pfIcYzi7Eeydid5dcNPKvg.
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
    /// Choice between different formats of securities quantity.
    /// </summary>
    [KnownType(typeof(Quantity55Choice.Code))]
    [KnownType(typeof(Quantity55Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity55Choice.Quantity))]
    [IsoId("_pfIcYzi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 55 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity55Choice_
    #else
    public abstract partial class Quantity55Choice_
    #endif
    {
    }
}
