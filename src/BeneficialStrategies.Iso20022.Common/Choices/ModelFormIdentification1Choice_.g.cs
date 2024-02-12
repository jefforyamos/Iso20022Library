﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModelFormIdentification1Choice.  ISO2002 ID# _929T03ltEeG7BsjMvd1mEw_-115804936.
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
    /// Choice of format for the model form identification.
    /// </summary>
    [KnownType(typeof(ModelFormIdentification1Choice.Code))]
    [KnownType(typeof(ModelFormIdentification1Choice.Proprietary))]
    [IsoId("_929T03ltEeG7BsjMvd1mEw_-115804936")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Model Form Identification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModelFormIdentification1Choice_
    #else
    public abstract partial class ModelFormIdentification1Choice_
    #endif
    {
    }
}
