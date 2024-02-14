﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TechnicalError1Choice.  ISO2002 ID# _pDbrZA3BEeWH49U6bkyMaA.
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
    /// Specifies the reason for the technical error.
    /// </summary>
    [KnownType(typeof(TechnicalError1Choice.Code))]
    [KnownType(typeof(TechnicalError1Choice.Proprietary))]
    [IsoId("_pDbrZA3BEeWH49U6bkyMaA")]
    [DisplayName("Technical Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TechnicalError1Choice_
    #else
    public abstract partial class TechnicalError1Choice_
    #endif
    {
    }
}
