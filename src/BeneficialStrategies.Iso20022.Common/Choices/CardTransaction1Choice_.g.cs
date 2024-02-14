﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CardTransaction1Choice.  ISO2002 ID# _t6ZGslkyEeGeoaLUQk__nA_-1316380729.
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
    /// Choice between a acquirer globalised card transaction or an individual card transaction.
    /// </summary>
    [KnownType(typeof(CardTransaction1Choice.Aggregated))]
    [KnownType(typeof(CardTransaction1Choice.Individual))]
    [IsoId("_t6ZGslkyEeGeoaLUQk__nA_-1316380729")]
    [DisplayName("Card Transaction 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardTransaction1Choice_
    #else
    public abstract partial class CardTransaction1Choice_
    #endif
    {
    }
}
