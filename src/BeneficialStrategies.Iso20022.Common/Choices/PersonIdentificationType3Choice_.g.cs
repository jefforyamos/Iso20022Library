﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PersonIdentificationType3Choice.  ISO2002 ID# _Ri-zudp-Ed-ak6NoX_4Aeg_-206772035.
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
    /// Specifies the type of identification of a person.
    /// </summary>
    [KnownType(typeof(PersonIdentificationType3Choice.Code))]
    [KnownType(typeof(PersonIdentificationType3Choice.Proprietary))]
    [IsoId("_Ri-zudp-Ed-ak6NoX_4Aeg_-206772035")]
    [DisplayName("Person Identification Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PersonIdentificationType3Choice_
    #else
    public abstract partial class PersonIdentificationType3Choice_
    #endif
    {
    }
}
