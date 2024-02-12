﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RegistrationProcessingStatus1Choice.  ISO2002 ID# _UYUpIdp-Ed-ak6NoX_4Aeg_170456881.
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
    /// Choice of format for the registration processing status.
    /// </summary>
    [KnownType(typeof(RegistrationProcessingStatus1Choice.Code))]
    [KnownType(typeof(RegistrationProcessingStatus1Choice.Proprietary))]
    [IsoId("_UYUpIdp-Ed-ak6NoX_4Aeg_170456881")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registration Processing Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RegistrationProcessingStatus1Choice_
    #else
    public abstract partial class RegistrationProcessingStatus1Choice_
    #endif
    {
    }
}
