﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References61Choice.  ISO2002 ID# _kTej8UHOEeazV4RAqPV71g.
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
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References61Choice.RelatedReference))]
    [KnownType(typeof(References61Choice.OtherReference))]
    [IsoId("_kTej8UHOEeazV4RAqPV71g")]
    [DisplayName("References 61 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References61Choice_
    #else
    public abstract partial class References61Choice_
    #endif
    {
    }
}
