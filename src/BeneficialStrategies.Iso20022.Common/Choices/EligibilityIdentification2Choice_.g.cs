﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EligibilityIdentification2Choice.  ISO2002 ID# _oDDY8eLXEeWFtOV72FbX9w.
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
    /// Specifies the eligibility details.
    /// </summary>
    [KnownType(typeof(EligibilityIdentification2Choice.Country))]
    [KnownType(typeof(EligibilityIdentification2Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(EligibilityIdentification2Choice.IssuerCSDIdentification))]
    [IsoId("_oDDY8eLXEeWFtOV72FbX9w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Eligibility Identification 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EligibilityIdentification2Choice_
    #else
    public abstract partial class EligibilityIdentification2Choice_
    #endif
    {
    }
}
