﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DataFormat2Choice.  ISO2002 ID# _Q6vvBdp-Ed-ak6NoX_4Aeg_-2133276556.
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
    /// Choice between the specification of the data in a structured or unstructured form.
    /// </summary>
    [KnownType(typeof(DataFormat2Choice.Structured))]
    [KnownType(typeof(DataFormat2Choice.Unstructured))]
    [IsoId("_Q6vvBdp-Ed-ak6NoX_4Aeg_-2133276556")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Data Format 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DataFormat2Choice_
    #else
    public abstract partial class DataFormat2Choice_
    #endif
    {
    }
}
