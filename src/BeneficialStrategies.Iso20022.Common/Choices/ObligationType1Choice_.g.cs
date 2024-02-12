﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ObligationType1Choice.  ISO2002 ID# _Ql4SSNp-Ed-ak6NoX_4Aeg_-44053834.
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
    /// Indicates the type of obligation.
    /// </summary>
    [KnownType(typeof(ObligationType1Choice.Code))]
    [KnownType(typeof(ObligationType1Choice.Proprietary))]
    [IsoId("_Ql4SSNp-Ed-ak6NoX_4Aeg_-44053834")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Obligation Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ObligationType1Choice_
    #else
    public abstract partial class ObligationType1Choice_
    #endif
    {
    }
}
