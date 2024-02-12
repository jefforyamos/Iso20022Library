﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PledgeeFormat3Choice.  ISO2002 ID# _8tov4TnZEeWV5sr121Fc8A.
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
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat3Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat3Choice.Identification))]
    [KnownType(typeof(PledgeeFormat3Choice.Proprietary))]
    [IsoId("_8tov4TnZEeWV5sr121Fc8A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pledgee Format 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PledgeeFormat3Choice_
    #else
    public abstract partial class PledgeeFormat3Choice_
    #endif
    {
    }
}
