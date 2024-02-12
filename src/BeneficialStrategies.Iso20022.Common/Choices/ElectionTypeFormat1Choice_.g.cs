﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ElectionTypeFormat1Choice.  ISO2002 ID# _Q3K2ktp-Ed-ak6NoX_4Aeg_1718215958.
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
    /// Choice between a standard code or proprietary code to specify the type of election movement.
    /// </summary>
    [KnownType(typeof(ElectionTypeFormat1Choice.Code))]
    [KnownType(typeof(ElectionTypeFormat1Choice.Proprietary))]
    [IsoId("_Q3K2ktp-Ed-ak6NoX_4Aeg_1718215958")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Election Type Format 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ElectionTypeFormat1Choice_
    #else
    public abstract partial class ElectionTypeFormat1Choice_
    #endif
    {
    }
}
