﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RemovalProcessing2Choice.  ISO2002 ID# __MbGwRIoEeyZaPkaPAzTvQ.
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
    /// Specifies the removal processing change requested and the reason.
    /// </summary>
    [KnownType(typeof(RemovalProcessing2Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(RemovalProcessing2Choice.IndexIdentification))]
    [KnownType(typeof(RemovalProcessing2Choice.IssuerCountry))]
    [IsoId("__MbGwRIoEeyZaPkaPAzTvQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Removal Processing 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RemovalProcessing2Choice_
    #else
    public abstract partial class RemovalProcessing2Choice_
    #endif
    {
    }
}
