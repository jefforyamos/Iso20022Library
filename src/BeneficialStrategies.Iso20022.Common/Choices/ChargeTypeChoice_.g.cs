﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeTypeChoice.  ISO2002 ID# _RIcz1Np-Ed-ak6NoX_4Aeg_-1267403817.
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
    /// Charge is expressed as a code or a bilaterally agreed code.
    /// </summary>
    [KnownType(typeof(ChargeTypeChoice.Code))]
    [KnownType(typeof(ChargeTypeChoice.ProprietaryCode))]
    [IsoId("_RIcz1Np-Ed-ak6NoX_4Aeg_-1267403817")]
    [DisplayName("Charge Type Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeTypeChoice_
    #else
    public abstract partial class ChargeTypeChoice_
    #endif
    {
    }
}
