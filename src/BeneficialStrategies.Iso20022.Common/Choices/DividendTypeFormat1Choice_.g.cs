﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DividendTypeFormat1Choice.  ISO2002 ID# _Q36dctp-Ed-ak6NoX_4Aeg_-2059778608.
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
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat1Choice.Code))]
    [KnownType(typeof(DividendTypeFormat1Choice.Proprietary))]
    [IsoId("_Q36dctp-Ed-ak6NoX_4Aeg_-2059778608")]
    [DisplayName("Dividend Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DividendTypeFormat1Choice_
    #else
    public abstract partial class DividendTypeFormat1Choice_
    #endif
    {
    }
}
