﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification36Choice.  ISO2002 ID# _PNQi0YrpEeq91phomTRDDA.
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
    [KnownType(typeof(SecurityIdentification36Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification36Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentification36Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentification36Choice.Basket))]
    [KnownType(typeof(SecurityIdentification36Choice.Index))]
    [KnownType(typeof(SecurityIdentification36Choice.IdentificationNotAvailable))]
    [IsoId("_PNQi0YrpEeq91phomTRDDA")]
    [DisplayName("Security Identification 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification36Choice_
    #else
    public abstract partial class SecurityIdentification36Choice_
    #endif
    {
    }
}
