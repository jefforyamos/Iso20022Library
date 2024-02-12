﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification6Choice.  ISO2002 ID# _TBKB79p-Ed-ak6NoX_4Aeg_-1421894985.
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
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification6Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification6Choice.OtherIdentification))]
    [KnownType(typeof(SecurityIdentification6Choice.InstrumentDescription))]
    [IsoId("_TBKB79p-Ed-ak6NoX_4Aeg_-1421894985")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification 6 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification6Choice_
    #else
    public abstract partial class SecurityIdentification6Choice_
    #endif
    {
    }
}
