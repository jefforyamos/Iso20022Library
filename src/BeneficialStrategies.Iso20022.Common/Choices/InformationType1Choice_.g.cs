﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InformationType1Choice.  ISO2002 ID# _RX8oaNp-Ed-ak6NoX_4Aeg_202651859.
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
    /// Specifies the type of additional information.
    /// </summary>
    [KnownType(typeof(InformationType1Choice.Code))]
    [KnownType(typeof(InformationType1Choice.Proprietary))]
    [IsoId("_RX8oaNp-Ed-ak6NoX_4Aeg_202651859")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Information Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InformationType1Choice_
    #else
    public abstract partial class InformationType1Choice_
    #endif
    {
    }
}
