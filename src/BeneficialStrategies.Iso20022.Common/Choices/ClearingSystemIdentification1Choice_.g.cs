﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClearingSystemIdentification1Choice.  ISO2002 ID# _TMLmMNp-Ed-ak6NoX_4Aeg_-1061546408.
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
    /// Information used to identify a cash clearing system.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification1Choice.ClearingSystemIdentification))]
    [KnownType(typeof(ClearingSystemIdentification1Choice.Proprietary))]
    [IsoId("_TMLmMNp-Ed-ak6NoX_4Aeg_-1061546408")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing System Identification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingSystemIdentification1Choice_
    #else
    public abstract partial class ClearingSystemIdentification1Choice_
    #endif
    {
    }
}
