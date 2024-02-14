﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OfferTypeFormat11Choice.  ISO2002 ID# _cta945KQEeWHWpTQn1FFVg.
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
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat11Choice.Code))]
    [KnownType(typeof(OfferTypeFormat11Choice.Proprietary))]
    [IsoId("_cta945KQEeWHWpTQn1FFVg")]
    [DisplayName("Offer Type Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OfferTypeFormat11Choice_
    #else
    public abstract partial class OfferTypeFormat11Choice_
    #endif
    {
    }
}
