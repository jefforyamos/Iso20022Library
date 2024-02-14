﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesAccountOrBusinessError3Choice.  ISO2002 ID# _yC-g5Tp1Eemk2e6qGBk8IQ.
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
    /// Choice between the securities account reference data or a business error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountOrBusinessError3Choice.BusinessError))]
    [IsoId("_yC-g5Tp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Or Business Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccountOrBusinessError3Choice_
    #else
    public abstract partial class SecuritiesAccountOrBusinessError3Choice_
    #endif
    {
    }
}
