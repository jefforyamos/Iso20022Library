﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingPosition1Choice.  ISO2002 ID# _QzcNINp-Ed-ak6NoX_4Aeg_135502517.
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
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition1Choice.Code))]
    [KnownType(typeof(ProcessingPosition1Choice.Proprietary))]
    [IsoId("_QzcNINp-Ed-ak6NoX_4Aeg_135502517")]
    [DisplayName("Processing Position 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition1Choice_
    #else
    public abstract partial class ProcessingPosition1Choice_
    #endif
    {
    }
}
