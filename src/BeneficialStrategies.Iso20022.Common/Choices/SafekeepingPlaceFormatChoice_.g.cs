﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SafekeepingPlaceFormatChoice.  ISO2002 ID# _RB5f5Np-Ed-ak6NoX_4Aeg_-418949931.
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
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormatChoice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsDSS))]
    [KnownType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsCountry))]
    [IsoId("_RB5f5Np-Ed-ak6NoX_4Aeg_-418949931")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Place Format Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormatChoice_
    #else
    public abstract partial class SafekeepingPlaceFormatChoice_
    #endif
    {
    }
}
