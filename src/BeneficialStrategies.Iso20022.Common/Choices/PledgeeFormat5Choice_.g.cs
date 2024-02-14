﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PledgeeFormat5Choice.  ISO2002 ID# _YdRwN9LGEeiN28wlpBQScw.
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
    [KnownType(typeof(PledgeeFormat5Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat5Choice.Identification))]
    [KnownType(typeof(PledgeeFormat5Choice.Proprietary))]
    [IsoId("_YdRwN9LGEeiN28wlpBQScw")]
    [DisplayName("Pledgee Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PledgeeFormat5Choice_
    #else
    public abstract partial class PledgeeFormat5Choice_
    #endif
    {
    }
}
