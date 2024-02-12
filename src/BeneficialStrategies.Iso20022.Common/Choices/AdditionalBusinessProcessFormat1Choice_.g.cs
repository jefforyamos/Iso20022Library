﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdditionalBusinessProcessFormat1Choice.  ISO2002 ID# _Q3dxgNp-Ed-ak6NoX_4Aeg_-250323431.
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
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat1Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat1Choice.Proprietary))]
    [IsoId("_Q3dxgNp-Ed-ak6NoX_4Aeg_-250323431")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Business Process Format 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat1Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat1Choice_
    #endif
    {
    }
}
