﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EUDividendStatusType2Choice.  ISO2002 ID# _PfdboTh8EeaH-93K5JKmzw.
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
    /// Choice of formats for the EU dividend status type.
    /// </summary>
    [KnownType(typeof(EUDividendStatusType2Choice.Code))]
    [KnownType(typeof(EUDividendStatusType2Choice.Proprietary))]
    [IsoId("_PfdboTh8EeaH-93K5JKmzw")]
    [DisplayName("EU Dividend Status Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUDividendStatusType2Choice_
    #else
    public abstract partial class EUDividendStatusType2Choice_
    #endif
    {
    }
}
