﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MeetingTypeClassification1Choice.  ISO2002 ID# _RDrokNp-Ed-ak6NoX_4Aeg_843703595.
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
    /// Choice of meeting type classification.
    /// </summary>
    [KnownType(typeof(MeetingTypeClassification1Choice.Code))]
    [KnownType(typeof(MeetingTypeClassification1Choice.Proprietary))]
    [IsoId("_RDrokNp-Ed-ak6NoX_4Aeg_843703595")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Meeting Type Classification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MeetingTypeClassification1Choice_
    #else
    public abstract partial class MeetingTypeClassification1Choice_
    #endif
    {
    }
}
