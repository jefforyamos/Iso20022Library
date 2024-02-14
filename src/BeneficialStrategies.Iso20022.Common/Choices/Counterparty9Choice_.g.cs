﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Counterparty9Choice.  ISO2002 ID# _GBj6HR5dEeWE3PufGMdJ3w.
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
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty9Choice.Seller))]
    [KnownType(typeof(Counterparty9Choice.Buyer))]
    [IsoId("_GBj6HR5dEeWE3PufGMdJ3w")]
    [DisplayName("Counterparty 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Counterparty9Choice_
    #else
    public abstract partial class Counterparty9Choice_
    #endif
    {
    }
}
