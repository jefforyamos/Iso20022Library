﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CardTransaction3Choice.  ISO2002 ID# _S1q3Ka6BEeexrtTFgmVD3Q.
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
    /// Choice between an acquirer globalised card transaction or an individual card transaction.
    /// </summary>
    [KnownType(typeof(CardTransaction3Choice.Aggregated))]
    [KnownType(typeof(CardTransaction3Choice.Individual))]
    [IsoId("_S1q3Ka6BEeexrtTFgmVD3Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Transaction 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardTransaction3Choice_
    #else
    public abstract partial class CardTransaction3Choice_
    #endif
    {
    }
}
