﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DocumentNumber5Choice.  ISO2002 ID# _CkuCkTnbEeWLJsP1cO-amg.
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
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber5Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber5Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber5Choice.ProprietaryNumber))]
    [IsoId("_CkuCkTnbEeWLJsP1cO-amg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Document Number 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DocumentNumber5Choice_
    #else
    public abstract partial class DocumentNumber5Choice_
    #endif
    {
    }
}
