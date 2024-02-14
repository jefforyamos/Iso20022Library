﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status28Choice.  ISO2002 ID# _thmBQZU8EeaYkf5FCqYMeA.
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
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status28Choice.Code))]
    [KnownType(typeof(Status28Choice.Proprietary))]
    [IsoId("_thmBQZU8EeaYkf5FCqYMeA")]
    [DisplayName("Status 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status28Choice_
    #else
    public abstract partial class Status28Choice_
    #endif
    {
    }
}
